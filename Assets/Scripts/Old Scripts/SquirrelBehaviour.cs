using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelBehaviour : MonoBehaviour
{
    [SerializeField] private Transform[] routes;
    private int routeToGo;
    private float tParam;
    private Vector2 squirrelPosition;
    private float speedModifier;
    private float acceleration;
    private bool coroutineAllowed;
    private Animator animator;
    private float timeElapsed;

    void Start()
    {
        routeToGo = 0;
        tParam = 0f;
        speedModifier = 0.05f;
        acceleration = 0.025f;
        coroutineAllowed = true;
        animator = GetComponent<Animator>();
        InvokeRepeating("IncreaseSpeed", 1f, 1f);
    }
    void Update()
    {
        if (coroutineAllowed)
            StartCoroutine(GoByTheRoute(routeToGo));

        timeElapsed += Time.deltaTime;

        switch (timeElapsed)
        {
            case float n when (n > 0 && n <= 4):
                animator.Play("Climbing");
                break;
            case float n when (n > 4 && n <= 5):
                animator.Play("JumpPrep");
                break;
            case float n when (n > 5):
                animator.Play("SQfly");
                break;
        }
    }
    public void IncreaseSpeed()
    {
        speedModifier += acceleration;
    }


    private IEnumerator GoByTheRoute(int routeNumber)
    {
        coroutineAllowed = false;

        Vector2 p0 = routes[routeNumber].GetChild(0).localPosition;
        Vector2 p1 = routes[routeNumber].GetChild(1).localPosition;
        Vector2 p2 = routes[routeNumber].GetChild(2).localPosition;
        Vector2 p3 = routes[routeNumber].GetChild(3).localPosition;

        while (tParam < 1)
        {
            tParam += Time.deltaTime * speedModifier;

            squirrelPosition = Mathf.Pow(1 - tParam, 3) * p0 +
                3 * Mathf.Pow(1 - tParam, 2) * tParam * p1 +
                3 * (1 - tParam) * Mathf.Pow(tParam, 2) * p2 +
                Mathf.Pow(tParam, 3) * p3;

            transform.localPosition = squirrelPosition;
            yield return new WaitForEndOfFrame();
        }

        tParam = 0f;
        routeToGo += 1;

        if (routeToGo > routes.Length - 1)
            routeToGo = 0;
        speedModifier = 0.05f;

        coroutineAllowed = true;

    }
}
