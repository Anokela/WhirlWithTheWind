using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeetleBehaviour : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    Rigidbody2D rb;
    // public GameObject beetle;
    Transform target;
    Vector2 moveDirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        target = GameObject.Find("PlayerChar").transform;
    }

    void Update()
    {
        if (target)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            //rb.rotation = angle;
            moveDirection = direction;
        }
    }

    void FixedUpdate()
    {
        if (rb.bodyType == RigidbodyType2D.Dynamic && target)
        {
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
        }
    }
    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.CompareTag("Player"))
        {
            Debug.Log("Da Opps be after ya fam!");
            rb.bodyType = RigidbodyType2D.Dynamic;
        }

    }
}