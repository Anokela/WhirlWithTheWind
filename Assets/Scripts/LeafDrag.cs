using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafDrag : MonoBehaviour
{
    // The animator component that controls the object's animations
    private Animator animator;
    private Rigidbody2D rb;
    public GameObject deathZone;

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
        }
        // Check if the collision is with a branch
        if (collision.gameObject.tag == "Branch" && rb.velocity.x < 0)
        {
            animator.SetBool("LeafDragLeft", true);
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bird"))
        {
            if (!PlayerInfo.IsSwiping && PlayerInfo.GameStarted)
            {
                collision.gameObject.SetActive(false);
                animator.SetBool("HitBird", true);
                Invoke("sendDeathMessage", 2f);
                PlayerInfo.GameStarted = false;
            }
        }
        if (collision.CompareTag("Beetle"))
        {
            if (!PlayerInfo.IsSwiping && PlayerInfo.GameStarted)
            {
                collision.gameObject.SetActive(false);
                animator.SetBool("HitBeetle", true);
                Invoke("sendDeathMessage", 2);
                PlayerInfo.GameStarted = false;
            }
        }
        if (collision.CompareTag("DeathZone"))
        {
            animator.SetBool("HitRoof", true);
            Invoke("sendDeathMessage", 2);
            PlayerInfo.GameStarted = false;
        }
    }

    void sendDeathMessage()
    {
        deathZone.SendMessage("OnPlayerDeath");
    }
}
