using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosePowerUp : MonoBehaviour
{
    private GameObject pc;
    private Vector3 spawnpoint;
    private GameObject menu;
    private GameObject sprout;
    private GameObject ttp;
    // Start is called before the first frame update
    void Start()
    {
        pc = GameObject.FindGameObjectWithTag("Player");
        spawnpoint = pc.transform.position;
        menu = GameObject.Find("SuccessMenu");
        sprout = GameObject.Find("Sprout");
        ttp = GameObject.Find("TapToPlay");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            pc.SetActive(true);
            pc.transform.position = spawnpoint;
            menu.SetActive(false);
            sprout.SetActive(false);
            ttp.SetActive(true);
        }
    }
}
