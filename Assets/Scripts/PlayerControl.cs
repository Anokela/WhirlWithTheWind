using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horizontalMovement;
    private bool controlsDisabled = false;
    private float speed = 200f;
    private float maxVelocity = 5.0f;
    private float JumpSpeed = 100f;
    public bool isLeftHeldDown = false;
    public bool isRightHeldDown = false;

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
          if(Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpSpeed);
        }
    }

    private void FixedUpdate()
    {
        if (!controlsDisabled) 
        {
            Debug.Log(isRightHeldDown);
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
        //Destroy the ligtPoint if Object tagged Player comes in contact with it
        if (c2d.CompareTag("LeftWall"))
        {
            maxVelocity = 25;
            controlsDisabled = true;
            Debug.Log("You crashed the left wall");
            rb.AddForce(Vector3.right * 25, ForceMode2D.Impulse);
            Invoke("ActivateControls", 0.5f);
            
        }
        if (c2d.CompareTag("RightWall"))
        {
            maxVelocity = 25;
            controlsDisabled = true;
            Debug.Log("You crashed the right wall");
            rb.AddForce(Vector3.left * 25, ForceMode2D.Impulse);
            Invoke("ActivateControls", 0.5f);
        }
    }

    void ActivateControls()
    {
        maxVelocity = 5f;
        controlsDisabled = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Mushroom")
        {
            controlsDisabled = true;
            Debug.Log("Bouncy!");
            rb.AddForce(Vector3.up * 50, ForceMode2D.Impulse);
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
