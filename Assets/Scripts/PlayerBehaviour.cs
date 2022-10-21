using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private Vector3 _prevPosition;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
       
    }

    void FreezePlayer()
    {
        rb.gravityScale = 0.25f;
        rb.constraints = RigidbodyConstraints2D.FreezePositionX;
        rb.bodyType = RigidbodyType2D.Kinematic;
        anim.enabled = false;
    }
    void UnFreezePlayer()
    {
        rb.gravityScale = 0.35f;
        rb.constraints = RigidbodyConstraints2D.None;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        rb.bodyType = RigidbodyType2D.Dynamic;
        anim.enabled = true;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Slowzone"))
        {
            rb.gravityScale = 0.0175f;
        }
        if (col.CompareTag("Freezezone"))
        {
            Invoke("FreezePlayer", 0.25f);
            Invoke("UnFreezePlayer", 2f);
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Slowzone"))
        {
            rb.gravityScale = 0.035f;
        }
    }
}
