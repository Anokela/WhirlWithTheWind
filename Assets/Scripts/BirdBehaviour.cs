using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBehaviour : MonoBehaviour
{
    [SerializeField] Transform[] Positions;
    [SerializeField] float objectSpeed;
    public GameObject Bird;
    int nextPosIndex;
    Transform nextPos;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        this.spriteRenderer = this.GetComponent<SpriteRenderer>();

    }
    // Start is called before the first frame update
    void Start()
    {
        nextPos = Positions[0];
        Bird = GameObject.FindWithTag("Bird");
    }

    // Update is called once per frame
    void Update()
    {
        MoveGameObject();
    }

    void MoveGameObject()
    {
        if (transform.localPosition == nextPos.localPosition)
        {
            nextPosIndex++;

            if (nextPosIndex >= Positions.Length)
            {
                nextPosIndex = 0;
            }
            nextPos = Positions[nextPosIndex];
        }
        else
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, nextPos.localPosition, objectSpeed * Time.deltaTime);
        }
        this.spriteRenderer.flipX = Bird.transform.localPosition.x > nextPos.transform.localPosition.x;
    }
}