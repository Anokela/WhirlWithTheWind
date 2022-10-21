using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeetleBehaviour : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    Rigidbody2D rb;
    Transform target;
    Vector2 moveDirection;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        this.spriteRenderer = this.GetComponent<SpriteRenderer>();

    }

    private void Start()
    {
        target = GameObject.Find("PlayerChar").transform;
    }

    void FixedUpdate()
    {
        if (target)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            //rb.rotation = angle;
            moveDirection = direction;
        }
        if (rb.bodyType == RigidbodyType2D.Dynamic && target)
        {
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
        }
        this.spriteRenderer.flipX = target.transform.position.x > this.transform.position.x;

    }
    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.CompareTag("Player"))
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
        }

    }
}