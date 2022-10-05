using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToPlay : MonoBehaviour
{
    private GameObject Panel;
    private GameObject ControlCanvas;
    private GameObject pc;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        ControlCanvas = GameObject.Find("ControlCanvas");
        ControlCanvas.SetActive(false);
        Panel = GameObject.Find("TapToPlay");
        pc = GameObject.FindGameObjectWithTag("Player");
        rb = pc.GetComponent<Rigidbody2D>();
        rb.simulated = false;
    }

    public void StartScene()
    {
        rb.velocity = Vector2.zero;
        rb.simulated = true;
        Panel.SetActive(false);
        ControlCanvas.SetActive(true);

    }
}