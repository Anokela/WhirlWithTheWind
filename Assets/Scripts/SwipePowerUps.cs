using UnityEngine;

public class SwipePowerUps : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 startPos;
    private Vector2 direction;
    private bool directionChosen;
    private float maxVelocity = 1.5f;
    public float dashSpeed;
    public float swipeMinLength;
    public float swipeAxisRestricor;
    public float swipeMaxLength;
    private Animator m_anim;
    private bool screenTouchStarted;
    private float screenTouchTime;
    private bool isLeftCoolDown;
    private bool isRightCoolDown;
    private bool isUpCoolDown;
    private bool isDownCoolDown;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        m_anim = GetComponent<Animator>();
        screenTouchTime = 0;
        isRightCoolDown = false;
        isLeftCoolDown = false;
        isUpCoolDown = false;
        isDownCoolDown = false;

    }

    void Update()
    {
        if (PlayerInfo.GameStarted)
        {
            if (screenTouchStarted)
            {
                screenTouchTime = screenTouchTime + Time.fixedDeltaTime;
            }


            if (rb.velocity.x > maxVelocity)
            {
                rb.velocity = new(maxVelocity, rb.velocity.y);
            }
            if (rb.velocity.x < -maxVelocity)
            {
                rb.velocity = new(-maxVelocity, rb.velocity.y);
            }
            if (rb.velocity.y > maxVelocity)
            {
                rb.velocity = new(rb.velocity.x, maxVelocity);
            }
            if (rb.velocity.y < -maxVelocity)
            {
                rb.velocity = new(rb.velocity.x, -maxVelocity);
            }
            // Track a single touch as a direction control.
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                // Handle finger movements based on touch phase.
                switch (touch.phase)
                {
                    // Record initial touch position.
                    case TouchPhase.Began:
                        startPos = touch.position;
                        screenTouchStarted = true;
                        directionChosen = false;
                        //Debug.Log(Time.fixedDeltaTime);
                        break;

                    // Determine direction by comparing the current touch position with the initial one.
                    case TouchPhase.Moved:
                        direction = touch.position - startPos;
                        break;

                    // Report that a direction has been chosen when the finger is lifted.
                    case TouchPhase.Ended:
                        if (screenTouchTime < 0.5f)
                        {
                            directionChosen = true;
                        }
                        screenTouchTime = 0f;
                        screenTouchStarted = false;
                        break;
                }
            }

            if (directionChosen)
            {
                maxVelocity = 5f;
                // Something that uses the chosen direction...
                // reduction values for x and y start and end
                //Debug.Log("y: "+ direction.y);
                //Debug.Log("x: " + direction.x);
                // absolute value of the reduction, if y > 100, horizontal swipe doesn't happen
                // makes sure of the intended direction of the swipe
                if (Mathf.Abs(direction.y) < swipeAxisRestricor && direction.x > swipeMinLength && Mathf.Abs(direction.x) < swipeMaxLength && PlayerInfo.SideDashActive == 1 && !isRightCoolDown)
                {
                    rb.gravityScale = 0;
                    rb.AddForce(Vector3.right * dashSpeed, ForceMode2D.Impulse);
                    directionChosen = false;
                    direction = Vector3.zero;
                    m_anim.SetBool("DashRight", true);
                    Invoke("resetAnimation", 0.25f);
                    isRightCoolDown = true;
                    Invoke("ResetRightCoolDown", 0.5f);
                }
                if (Mathf.Abs(direction.y) < swipeAxisRestricor && direction.x < -swipeMinLength && Mathf.Abs(direction.x) < swipeMaxLength && PlayerInfo.SideDashActive == 1 && !isLeftCoolDown)
                {
                    rb.gravityScale = 0;
                    rb.AddForce(Vector3.left * dashSpeed, ForceMode2D.Impulse);
                    directionChosen = false;
                    direction = Vector3.zero;
                    m_anim.SetBool("DashLeft", true);
                    Invoke("resetAnimation", 0.25f);
                    isLeftCoolDown = true;
                    Invoke("ResetLeftCoolDown", 0.5f);
                }
                if (Mathf.Abs(direction.x) < swipeAxisRestricor && direction.y < -swipeMinLength && PlayerInfo.DownDashActive == 1 && !isDownCoolDown)
                {
                    rb.gravityScale = 0;
                    rb.AddForce(Vector3.down * dashSpeed, ForceMode2D.Impulse);
                    directionChosen = false;
                    m_anim.SetBool("DashDown", true);
                    Invoke("resetAnimation", 0.25f);
                    direction = Vector3.zero;
                    isDownCoolDown = true;
                    Invoke("ResetDownCoolDown", 0.5f);
                }
                if (Mathf.Abs(direction.x) < swipeAxisRestricor && direction.y > swipeMinLength && PlayerInfo.UpDashActive == 1 && !isUpCoolDown)
                {
                    rb.gravityScale = 0;
                    rb.AddForce(Vector3.up * dashSpeed, ForceMode2D.Impulse);
                    directionChosen = false;
                    m_anim.SetBool("DashUp", true);
                    Invoke("resetAnimation", 0.25f);
                    direction = Vector3.zero;
                    isUpCoolDown = true;
                    Invoke("ResetUpCoolDown", 0.5f);
                }
            }
        }
    }

    private void resetAnimation()
    {
        m_anim.SetBool("DashRight", false);
        m_anim.SetBool("DashLeft", false);
        m_anim.SetBool("DashDown", false);
        m_anim.SetBool("DashUp", false);
        maxVelocity = 1.5f;
    }

    private void ResetRightCoolDown ()
    {
        isRightCoolDown = false;
    }

    private void ResetLeftCoolDown()
    {
        isLeftCoolDown = false;
    }

    private void ResetUpCoolDown()
    {
        isUpCoolDown = false;
    }
    private void ResetDownCoolDown()
    {
        isDownCoolDown = false;
    }
}  
