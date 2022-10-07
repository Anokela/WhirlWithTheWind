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
