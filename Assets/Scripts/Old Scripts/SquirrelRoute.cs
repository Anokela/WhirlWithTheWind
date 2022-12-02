using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelRoute : MonoBehaviour
{
    [SerializeField] private Transform[] controlPoints;
    private Vector2 gizmosPosition;

    private void OnDrawGizmos()
    {
        for (float t = 0; t <= 1; t += 0.05f)
        {
            gizmosPosition = Mathf.Pow(1 - t, 3) * controlPoints[0].localPosition +
                3 * Mathf.Pow(1 - t, 2) * t * controlPoints[1].localPosition +
                3 * (1 - t) * Mathf.Pow(t, 2) * controlPoints[2].localPosition +
                Mathf.Pow(t, 3) * controlPoints[3].localPosition;

            Gizmos.DrawSphere(gizmosPosition, 0.25f);
        }

        Gizmos.DrawLine(new Vector2(controlPoints[0].localPosition.x, controlPoints[0].localPosition.y),
           new Vector2(controlPoints[1].localPosition.x, controlPoints[1].localPosition.y));

        Gizmos.DrawLine(new Vector2(controlPoints[2].localPosition.x, controlPoints[2].localPosition.y),
           new Vector2(controlPoints[3].localPosition.x, controlPoints[3].localPosition.y));
    }
}
