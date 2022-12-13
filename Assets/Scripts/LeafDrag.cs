using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafDrag : MonoBehaviour
{
    // The animator component that controls the object's animations
    private Animator animator;
    private Rigidbody2D rb;

    void Start()
    {
        // Get the animator component
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        animator.SetBool("LeafDragRight", false);
        animator.SetBool("LeafDragLeft", false);
    }

    void Update()
    {
        // Get the current velocity of the object
        

    }

    void OnCollisionStay2D(Collision2D collision)
    {
        // Check if the collision is with a branch
        if (collision.gameObject.tag == "Branch" && rb.velocity.x > 0)
        {
            animator.SetBool("LeafDragRight", true);
            Debug.Log("toimii");
        }
        // Check if the collision is with a branch
        if (collision.gameObject.tag == "Branch" && rb.velocity.x < 0)
        {
            animator.SetBool("LeafDragLeft", true);
            Debug.Log("toimii2");
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Branch")
        {
            animator.SetBool("LeafDragRight", false);
            animator.SetBool("LeafDragLeft", false);
        }
    }
}
