using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPopUp : MonoBehaviour
{
    private GameObject Panel;

    void Start()
    {
        Panel = GameObject.Find("PopUp");
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
        Panel.SetActive(true);
        Time.timeScale = 0;
    }
}
