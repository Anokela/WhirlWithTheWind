using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject playerChar;
    private bool controlsDisabled = false;
    public float bounceForce;
    public  float movementDelay;
    private float movementStartTime = 0.1f;
    public FixedJoystick joyStick;
    public GameObject deathZone;
    private Animator m_anim;

    // Start is called before the first frame update
    void Start()
    {
        m_anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (PlayerInfo.GameStarted)
        {
            if (!controlsDisabled)
            {
                if (Time.time > movementStartTime)
                {
                    rb.AddForce(new Vector3(joyStick.Horizontal * Time.deltaTime * PlayerInfo.BoxSpeed * 0.3f, joyStick.Vertical * Time.deltaTime * PlayerInfo.BoxSpeed * 0.3f), ForceMode2D.Force);
                }
            }
        }
    }

    void OnTriggerStay2D(Collider2D c2d)
    {
        if (c2d.CompareTag("LeftWall"))
        {
            controlsDisabled = true;
            rb.AddForce(Vector3.right * bounceForce, ForceMode2D.Impulse);
            Invoke("ActivateControls", 0.5f);
        }
        if (c2d.CompareTag("RightWall"))
        {
            controlsDisabled = true;
            rb.AddForce(Vector3.left * bounceForce, ForceMode2D.Impulse);
            Invoke("ActivateControls", 0.5f);
        }
        if (c2d.CompareTag("LevelFloor"))
        {
            controlsDisabled = true;
            rb.AddForce(Vector3.up * bounceForce, ForceMode2D.Impulse);
            Invoke("ActivateControls", 0.5f);
        }
    }

    //Death animations activation
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bird"))
        {
            if (!PlayerInfo.IsSwiping && PlayerInfo.GameStarted)
            {
                collision.gameObject.SetActive(false);
                m_anim.SetBool("HitBird", true);
                Invoke("sendDeathMessage", 2f);
                PlayerInfo.GameStarted = false;
            }
        }
        if (collision.CompareTag("Beetle"))
        {
            if (!PlayerInfo.IsSwiping && PlayerInfo.GameStarted)
            {
                collision.gameObject.SetActive(false);
                m_anim.SetBool("HitBeetle", true);
                Invoke("sendDeathMessage", 2);
                PlayerInfo.GameStarted = false;
            }
        }
        if (collision.CompareTag("DeathZone"))
        {
            m_anim.SetBool("HitRoof", true);
            Invoke("sendDeathMessage", 2);
            PlayerInfo.GameStarted = false;
        }
    }

    void sendDeathMessage()
    {
        deathZone.SendMessage("OnPlayerDeath");
    }

    void ActivateControls()
    {
        controlsDisabled = false;
    }    
}