using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horizontalMovement;
    private bool controlsDisabled = false;
    public float speed = 15f;
    public float maxVelocity = 7.5f;
    
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
    }

    private void FixedUpdate()
    {
        if (!controlsDisabled) 
        {
            rb.AddForce(new Vector3(horizontalMovement * Time.deltaTime * speed, 0), ForceMode2D.Impulse);
        }
    }
    void OnTriggerEnter2D(Collider2D c2d)
    {
        //Destroy the ligtPoint if Object tagged Player comes in contact with it
        if (c2d.CompareTag("LeftWall"))
        {
            controlsDisabled = true;
            Debug.Log("You crashed the left wall");
            rb.AddForce(Vector3.right * 25, ForceMode2D.Impulse);
            Invoke("ActivateControls", 0.5f);
        }
        if (c2d.CompareTag("RightWall"))
        {
            controlsDisabled = true;
            Debug.Log("You crashed the right wall");
            rb.AddForce(Vector3.left * 25, ForceMode2D.Impulse);
            Invoke("ActivateControls", 0.5f);
        }
    }

    void ActivateControls()
    {
        controlsDisabled = false;
    }
}
