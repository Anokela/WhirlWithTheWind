using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTouchControl : MonoBehaviour
{
    private Rigidbody2D rb;
    private GameObject cam;
    private GameObject pc;
    public float speed;
    public float maxVelocity;
    public float movementDelay = 0.5f;
    public float movementStartTime = 0.5f;
    private bool controlsDisabled = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = GameObject.Find("Main Camera");
        pc = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (!controlsDisabled)
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                Vector3 touchPoint = Camera.main.ScreenToWorldPoint(touch.position);
                switch (touch.phase)
                {
                    case TouchPhase.Ended:
                        movementStartTime = Time.time + movementDelay;
                        break;
                }
                if (Time.time > movementStartTime)
                {
                    if (rb.velocity.x > maxVelocity)
                    {
                        rb.velocity = new(maxVelocity, rb.velocity.y);
                    }

                    if (rb.velocity.x < -maxVelocity)
                    {
                        rb.velocity = new(-maxVelocity, rb.velocity.y);
                    }
                    if (touchPoint.x < pc.transform.position.x)
                    {
                        rb.AddForce(new Vector3(1f * speed * Time.deltaTime, 0), ForceMode2D.Force);
                    }
                    if (touchPoint.x > pc.transform.position.x)
                    {
                        rb.AddForce(new Vector3(-1f * speed * Time.deltaTime, 0), ForceMode2D.Force);
                    }
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
    }

    void ActivateControls()
    {
        controlsDisabled = false;
    }
}
