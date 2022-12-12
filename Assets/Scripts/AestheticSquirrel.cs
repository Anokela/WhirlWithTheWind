using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AestheticSquirrel : MonoBehaviour
{
    // The object's starting position
    public Vector3 pointA = new Vector3(0, 0, 0);

    // The object's ending position
    public Vector3 pointB = new Vector3(0, 10, 0);

    // The speed at which the object moves
    public float speed = 1.0f;

    // The object's animator component
    private Animator animator;

    void Start()
    {
        // Get the object's animator component
        animator = GetComponent<Animator>();

        // Move the object from point A to point B
        StartCoroutine(MoveFromAtoB());
    }

    IEnumerator MoveFromAtoB()
    {
        // Move the object towards point B
        while (transform.localPosition != pointB)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, pointB, speed * Time.deltaTime);
            yield return null;
        }

        // Swap the object's animation at point B
        animator.SetTrigger("JumpPrep");
    }
}