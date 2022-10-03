using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindObstacle : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    public Vector3 windDirection;
    public float windForce;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerChar");
        rb = player.GetComponent<Rigidbody2D>();
        Debug.Log(rb);
    }

    // Update is called once per frame
   /* void Update()
    {
        rb.AddForce(new Vector3(windDirection.x * Time.deltaTime * windForce, 0), ForceMode2D.Force);
    }*/

    void OnTriggerStay2D(Collider2D c2d)
    {
        if (c2d.CompareTag("Player"))
        {
            if ( windDirection.x > 0)
            {
                rb.AddForce(Vector3.right * windForce, ForceMode2D.Force);
                // rb.AddForce(new Vector3(windDirection.x * Time.deltaTime * windForce, 0), ForceMode2D.Force);
                Debug.Log("Testi");
            }

            if (windDirection.x < 0)
            {
                rb.AddForce(Vector3.left * windForce, ForceMode2D.Force);
                // rb.AddForce(new Vector3(windDirection.x * Time.deltaTime * windForce, 0), ForceMode2D.Force);
                Debug.Log("Testi");
            }
        }
    }
}
