
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject playerChar;
    [SerializeField] float moveSpeed = 1f;
    // private Vector3 startPos;
    private bool isMoving = false;
    Vector3 touchPosition, whereToMove;
    private bool controlsDisabled = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
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
                    rb.AddForce(new Vector3(whereToMove.x * Time.deltaTime * moveSpeed, whereToMove.y * Time.deltaTime * moveSpeed), ForceMode2D.Force);
                }   
            }

        }
    }
    void OnTriggerStay2D(Collider2D c2d)
    {
        if (c2d.CompareTag("LeftWall"))
        {
            controlsDisabled = true;
            rb.AddForce(Vector3.right * 0.005f, ForceMode2D.Impulse);
            Invoke("ActivateControls", 0.5f);

        }
        if (c2d.CompareTag("RightWall"))
        {
            controlsDisabled = true;
            rb.AddForce(Vector3.left * 0.005f, ForceMode2D.Impulse);
            Invoke("ActivateControls", 0.5f);
        }

        if (c2d.CompareTag("LevelFloor"))
        {
            controlsDisabled = true;
            rb.AddForce(Vector3.up * 0.005f, ForceMode2D.Impulse);
            Invoke("ActivateControls", 0.5f);
        }
    }

    void ActivateControls()
    {
        controlsDisabled = false;
    }
}
