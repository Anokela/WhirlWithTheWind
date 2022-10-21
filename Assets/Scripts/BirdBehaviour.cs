using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBehaviour : MonoBehaviour
{

    public Vector3 pos1;
    public Vector3 pos2;
    public float speed = 1.0f;
    public GameObject bird;
    private bool m_FacingRight = true;

    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Bird");
    }
    void FixedUpdate() {
         transform.position = Vector3.Lerp (pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));

        if (bird.transform.position == pos2)
        {
            Flip();
        }
        if (bird.transform.position == pos1)
        {
            Flip();
        }
    }

    void Flip()
    {
       
        m_FacingRight = !m_FacingRight;

     
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}