using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horizontalMovement;
    private bool controlsDisabled = false;
    public float speed = 1f;
    public float maxVelocity = 0.75f;
    public float JumpSpeed = 1f;
    public float bouncePower = 0.15f;
    private bool isLeftHeldDown = false;
    private bool isRightHeldDown = false;
    private float Dive = -10f;

    public float CoolDownTime = 2;
    private float NextJumpTime = 0;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {   
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        if (rb.velocity.x > maxVelocity)
        {
            rb.velocity = new(maxVelocity, rb.velocity.y);
        }

        if (rb.velocity.x < -maxVelocity)
        {
            rb.velocity = new(-maxVelocity, rb.velocity.y);
        }
        if (Time.time > NextJumpTime)
         {
          if(Input.GetButtonDown("Jump"))
            {
                rb.velocity = new Vector2(rb.velocity.x, JumpSpeed);
                NextJumpTime = Time.time + CoolDownTime;
            }
            if (Input.GetButtonDown("Vertical"))
        {
            rb.velocity = new(rb.velocity.x, Dive);
            rb.velocity = new Vector2(rb.velocity.x, Dive);
        }

        }

    }

    private void FixedUpdate()
    {
        if (!controlsDisabled) 
        {
            if (isLeftHeldDown)
            {
                rb.AddForce(new Vector3(1f * Time.deltaTime * speed, 0), ForceMode2D.Impulse);
            }

            if (isRightHeldDown)
            {
                rb.AddForce(new Vector3(-1f * Time.deltaTime * speed, 0), ForceMode2D.Impulse);
            }

            rb.AddForce(new Vector3(horizontalMovement * Time.deltaTime * speed, 0), ForceMode2D.Impulse);
        }
    }
    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.CompareTag("LeftWall"))
        {
            maxVelocity = 1f;
            controlsDisabled = true;
            rb.AddForce(Vector3.right * 0.6f, ForceMode2D.Impulse);
            Invoke("ActivateControls", 0.5f);
            
        }
        if (c2d.CompareTag("RightWall"))
        {
            maxVelocity = 1f;
            controlsDisabled = true;
            rb.AddForce(Vector3.left * 0.6f, ForceMode2D.Impulse);
            Invoke("ActivateControls", 0.5f);
        }
    }

    void ActivateControls()
    {
        maxVelocity = 0.75f;
        controlsDisabled = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Mushroom")
        {
            controlsDisabled = true;
            rb.AddForce(Vector3.up * bouncePower, ForceMode2D.Impulse);
            Invoke("ActivateControls", 0.5f);
        }
    }

    public void LeftButtonPressed() 
    {
        isLeftHeldDown = true;
    }

    public void RightButtonPressed()
    {
        isRightHeldDown = true;
    }

    public void ButtonReleaseRight()
    {
        isRightHeldDown = false;
    }

    public void ButtonReleaseLeft()
    {
        isLeftHeldDown = false;
    }
}
