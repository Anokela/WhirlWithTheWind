using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horizontalMovement;
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
        rb.AddForce(new Vector3(horizontalMovement * Time.deltaTime * speed, 0), ForceMode2D.Impulse);
    }
}
