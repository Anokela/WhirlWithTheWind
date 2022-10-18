using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSuccessMenu : MonoBehaviour
{
    private GameObject Panel;
    public GameObject pc;
    private Rigidbody2D rb;
    // private GameObject sprout;
 
    void Start()
    {
        pc = GameObject.FindGameObjectWithTag("Player");
        rb = pc.GetComponent<Rigidbody2D>();
        // sprout = GameObject.Find("Sprout");
        Panel = GameObject.Find("SuccessMenu");
        Panel.SetActive(false);
        // sprout.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.CompareTag("Player"))
        {
            Invoke("showPanel", 0);
        }
    }

    public void showPanel()
    {
        rb.velocity = Vector2.zero;
        rb.simulated = false;
        Panel.SetActive(true);
        // sprout.SetActive(true);
        pc.SetActive(false);
    }
}
