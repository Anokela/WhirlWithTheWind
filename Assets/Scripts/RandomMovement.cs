using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float speed;
    private float waitTime;
    public float startWaitTime;
    Transform target;
    public Transform moveSpot;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        this.spriteRenderer = this.GetComponent<SpriteRenderer>();

    }

    private void Start()
    {
        waitTime = startWaitTime;
        moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        target = GameObject.Find("PlayerChar").transform;
    }

    void FixedUpdate()
    {
        transform.localPosition = Vector2.MoveTowards(transform.localPosition, moveSpot.localPosition, speed * Time.deltaTime);
        if (Vector2.Distance(transform.localPosition, moveSpot.localPosition) < 0.2f)
        {
            if (waitTime <= 0)
            {
                moveSpot.localPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
        this.spriteRenderer.flipX = target.transform.localPosition.x > this.transform.localPosition.x;
    }
}
