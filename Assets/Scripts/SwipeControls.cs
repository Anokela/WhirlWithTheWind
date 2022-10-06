using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeControls : MonoBehaviour
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

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ogGravity = rb.gravityScale;
    }
    
    void Update()
    {
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
            if(Mathf.Abs(direction.y) < swipeAxisRestricor && direction.x > swipeLength)
            {
                rb.gravityScale = 0;
                rb.AddForce(Vector3.right * dashSpeed, ForceMode2D.Impulse);
                directionChosen = false;
                Invoke("NormalizeGravity", invokeDelaySeconds);
                direction = Vector3.zero;
            }
            if (Mathf.Abs(direction.y) < swipeAxisRestricor && direction.x < -swipeLength)
            {
                rb.gravityScale = 0;
                rb.AddForce(Vector3.left * dashSpeed, ForceMode2D.Impulse);
                directionChosen = false;
                Invoke("NormalizeGravity", invokeDelaySeconds);
                direction = Vector3.zero;
            }
            if (Mathf.Abs(direction.x) < swipeAxisRestricor && direction.y < -swipeLength)
            {
                rb.gravityScale = 0;
                rb.AddForce(Vector3.down * dashSpeed, ForceMode2D.Impulse);
                directionChosen = false;
                Invoke("NormalizeGravity", invokeDelaySeconds);
                direction = Vector3.zero;
            }
            if (Mathf.Abs(direction.x) < swipeAxisRestricor && direction.y > swipeLength)
            {
                rb.gravityScale = 0;
                rb.AddForce(Vector3.up * dashSpeed, ForceMode2D.Impulse);
                directionChosen = false;
                Invoke("NormalizeGravity", invokeDelaySeconds);
                direction = Vector3.zero;
            }
        }
    }
    private void NormalizeGravity()
    {
        rb.gravityScale = ogGravity;
    }
}  









    // Update is called once per frame
/*    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            SubX = endTouchPosition.x - startTouchPosition.x;
            SubY = endTouchPosition.y - startTouchPosition.y;
            endTouchPosition = Input.GetTouch(0).position;
            //left swipe
            if(endTouchPosition.x < startTouchPosition.x && (SubY) > (SubX))
            {
                rb.AddForce(new Vector3(-1 * Time.deltaTime * 2f, 0), ForceMode2D.Impulse);
            }

            if (endTouchPosition.x > startTouchPosition.x && (SubY) > (SubX))
            {
                rb.AddForce(new Vector3(1 * Time.deltaTime * 2f, 0), ForceMode2D.Impulse);
            }

            if (endTouchPosition.y < startTouchPosition.y && (SubY) > (SubX))
            {
                rb.AddForce(new Vector3(0, -1 * Time.deltaTime * 2f), ForceMode2D.Impulse);
            }

            if (endTouchPosition.y > startTouchPosition.y && (SubY) > (SubX))
            {
                rb.AddForce(new Vector3(0, 1 * Time.deltaTime * 2f), ForceMode2D.Impulse);
            }
        }
    }*/
//}
