using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToPlay : MonoBehaviour
{
    private GameObject Panel;
    // private GameObject ControlCanvas;
    public GameObject pc;
    public GameObject speedManager;
    public GameObject distanceManager;
    // private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
        Time.timeScale = 0;
        Panel = GameObject.Find("TapToPlay");
        // pc = GameObject.FindGameObjectWithTag("Player");
       // rb = pc.GetComponent<Rigidbody2D>();
        // rb.simulated = false;
    }

    public void StartScene()
    {
        speedManager.SendMessage("AccelerateBoxSpeed");
        distanceManager.SendMessage("MeasureDistance");
        // rb.velocity = Vector2.zero;
        // rb.simulated = true;
        Panel.SetActive(false);
        Time.timeScale = 1;
    }
}