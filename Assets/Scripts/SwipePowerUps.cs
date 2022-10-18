using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipePowerUps : MonoBehaviour
{
    private Rigidbody2D rb;
    private float ogGravity;
    private Vector2 startPos;
    private Vector2 direction;
    private bool directionChosen;
    public float maxVelocity = 1f;
    public float dashSpeed = 0.1f;
    public float invokeDelaySeconds = 0.8f;
    public float swipeLength = 200f;
    public float swipeAxisRestricor = 100f;

    public bool dashUpPowerUp = false;
    public bool dashDownPowerUp = false;
    public bool dashRightPowerUp = true;
    public bool dashLeftPowerUp = true;
    private Animator m_anim;

    // Start is called before the first frame update
    void Start()
    {
        /*if (PlayerPrefs.HasKey("UpDashActive"))
        {
            if (PlayerPrefs.GetInt("UpDashActive") == 1)
            {
                dashUpPowerUp = true;
            }
        }*/
        rb = GetComponent<Rigidbody2D>();
        ogGravity = rb.gravityScale;
        m_anim = GetComponent<Animator>();
    }
    
    void Update()
    {
        if (PlayerPrefs.HasKey("UpDashActive"))
        {
            if (PlayerPrefs.GetInt("UpDashActive") == 1)
            {
                dashUpPowerUp = true;
            }
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
                    directionChosen = false;
                    break;

                // Determine direction by comparing the current touch position with the initial one.
                case TouchPhase.Moved:
                    direction = touch.position - startPos;
                    break;

                // Report that a direction has been chosen when the finger is lifted.
                case TouchPhase.Ended:
                    directionChosen = true;
                    break;
            }
        }
       
        if (directionChosen)
        {
            // Something that uses the chosen direction...
            // reduction values for x and y start and end
            Debug.Log(direction.y);
            Debug.Log(direction.x);
            // absolute value of the reduction, if y > 100, horizontal swipe doesn't happen
            // makes sure of the intended direction of the swipe
            if(Mathf.Abs(direction.y) < swipeAxisRestricor && direction.x > swipeLength && dashRightPowerUp)
            {
                rb.gravityScale = 0;
                //rb.AddForce(Vector3.right * dashSpeed, ForceMode2D.Impulse);
                Invoke("DashRight", 0.35f);
                directionChosen = false;
                Invoke("NormalizeGravity", invokeDelaySeconds);
                direction = Vector3.zero;
                m_anim.SetBool("DashRight", true);
                Invoke("resetAnimation", 0.5f);
            }
            if (Mathf.Abs(direction.y) < swipeAxisRestricor && direction.x < -swipeLength && dashLeftPowerUp)
            {
                rb.gravityScale = 0;
                //rb.AddForce(Vector3.left * dashSpeed, ForceMode2D.Impulse);
                Invoke("DashLeft", 0.35f);
                directionChosen = false;
                Invoke("NormalizeGravity", invokeDelaySeconds);
                direction = Vector3.zero;
                m_anim.SetBool("DashLeft", true);
                Invoke("resetAnimation", 0.5f);
            }
            if (Mathf.Abs(direction.x) < swipeAxisRestricor && direction.y < -swipeLength && dashDownPowerUp)
            {
                rb.gravityScale = 0;
                // rb.AddForce(Vector3.down * dashSpeed, ForceMode2D.Impulse);
                Invoke("DashDown", 0.45f);
                directionChosen = false;
                Invoke("NormalizeGravity", invokeDelaySeconds);
                m_anim.SetBool("DashDown", true);
                Invoke("resetAnimation", 0.55f);
                direction = Vector3.zero;
            }
            if (Mathf.Abs(direction.x) < swipeAxisRestricor && direction.y > swipeLength && dashUpPowerUp)
            {
                rb.gravityScale = 0;
                // rb.AddForce(Vector3.up * dashSpeed, ForceMode2D.Impulse);
                Invoke("DashUp", 0.5f);
                directionChosen = false;
                m_anim.SetBool("DashUp", true);
                Invoke("NormalizeGravity", invokeDelaySeconds);
                Invoke("resetAnimation", 0.55f);
                direction = Vector3.zero;
            }
        }
    }
    private void NormalizeGravity()
    {
        rb.gravityScale = ogGravity;
    }

    private void resetAnimation()
    {
        m_anim.SetBool("DashRight", false);
        m_anim.SetBool("DashLeft", false);
        m_anim.SetBool("DashDown", false);
        m_anim.SetBool("DashUp", false);
    }

    private void DashRight()
    {
        rb.AddForce(Vector3.right * dashSpeed, ForceMode2D.Impulse);
    }

    private void DashLeft()
    {
        rb.AddForce(Vector3.left * dashSpeed, ForceMode2D.Impulse);
    }

    private void DashDown()
    {
        rb.AddForce(Vector3.down * dashSpeed, ForceMode2D.Impulse);
    }

    private void DashUp()
    {
        rb.AddForce(Vector3.up * dashSpeed, ForceMode2D.Impulse);
    }
}  
