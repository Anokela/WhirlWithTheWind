using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPoint : MonoBehaviour
{
    private GameObject lightPoint;
    void Awake()
    {
        //Make Collider2D as trigger 
        GetComponent<Collider2D>().isTrigger = true;
    }

    private void Start()
    {
        lightPoint = this.gameObject;
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
        //Destroy the ligtPoint if Object tagged Player comes in contact with it
        if (c2d.CompareTag("Player"))
        {
            //Add lightPoint to counter
            PlayerInfo.RunLightPoints++;
            PlayerInfo.LightPoints++;
            lightPoint.SetActive(false);
            Invoke("ActivateLightPoint", 4/PlayerInfo.BoxSpeed);
        }
    }

    void ActivateLightPoint ()
    {
        lightPoint.SetActive(true);
    }
}
