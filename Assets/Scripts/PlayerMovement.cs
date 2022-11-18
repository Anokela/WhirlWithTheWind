
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject playerChar;
    // private bool isMoving = false;
    // Vector3 touchPosition, whereToMove;
    private bool controlsDisabled = false;
    public float bounceForce;
    public  float movementDelay;
    private float movementStartTime = 0.1f;
    public FixedJoystick joyStick;

    // Start is called before the first frame update
    void Start()
    {
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
                    rb.AddForce(new Vector3(joyStick.Horizontal * Time.deltaTime * PlayerInfo.BoxSpeed * 0.4f, joyStick.Vertical * Time.deltaTime * PlayerInfo.BoxSpeed * 0.2f), ForceMode2D.Force);
                }
            }
            /*if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                whereToMove = (touchPosition - transform.position);

                // Handle finger movements based on touch phase.
                switch (touch.phase)
                {
                    // When player touches screen, start player character movement
                    case TouchPhase.Began:

                        isMoving = true;
                        movementStartTime = Time.time + movementDelay;
                        break;

                    // Stop player character movement when the finger is lifted.
                    case TouchPhase.Ended:
                        isMoving = false;
                        break;
                }
                // If player character is moving, move it towards the finger on the screen
                if (isMoving)
                {
                    if (!controlsDisabled)
                    {
                        if (Time.time > movementStartTime)
                        {
                            rb.AddForce(new Vector3(joyStick.Horizontal * Time.deltaTime * PlayerInfo.BoxSpeed * 0.4f, joyStick.Vertical * Time.deltaTime * PlayerInfo.BoxSpeed * 0.2f), ForceMode2D.Force);
                        }
                    }
                }
            }*/
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

    void ActivateControls()
    {
        controlsDisabled = false;
    }    
}