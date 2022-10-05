using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPopUp : MonoBehaviour
{
    private GameObject Panel;
    private GameObject pc;
    private Rigidbody2D rb;

    void Start()
    {
        pc = GameObject.FindGameObjectWithTag("Player");
        rb = pc.GetComponent<Rigidbody2D>();
        Panel = GameObject.Find("RestartMenu");
        Panel.SetActive(false);
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
        rb.simulated = false;
        Panel.SetActive(true);
    }
}
