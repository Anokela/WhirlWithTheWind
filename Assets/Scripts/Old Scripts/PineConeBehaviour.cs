using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PineConeBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.CompareTag("PineConeToggle"))
        {
            Debug.Log("a Pine cone has fallen!");
            rb.bodyType = RigidbodyType2D.Dynamic;
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Mushroom")
        {
            Debug.Log("Bouncy!");
            rb.AddForce(Vector3.up * 25, ForceMode2D.Impulse);
        }
    }
}
