using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColdPoint : MonoBehaviour
{
    private GameObject coldPoint;
    private GameObject soundManager;
    void Awake()
    {
        //Make Collider2D as trigger 
        GetComponent<Collider2D>().isTrigger = true;
    }

    private void Start()
    {
        soundManager = GameObject.Find("EndlessSoundManager");
        coldPoint = this.gameObject;
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
        //Destroy the coldPoint if Object tagged Player comes in contact with it
        if (c2d.CompareTag("Player"))
        {
            if (PlayerInfo.GameStarted)
            {
                //Rmove lightPoints from counter
                
                PlayerInfo.LightPoints = PlayerInfo.LightPoints - 10;
                soundManager.SendMessage("PlayLightPointSound");
                coldPoint.SetActive(false);
                Invoke("ActivateLightPoint", 4 / PlayerInfo.BoxSpeed);
                if (PlayerInfo.LightPoints < 0)
                {
                    PlayerInfo.LightPoints = 0;
                }
            }
        }
    }

    void ActivateLightPoint()
    {
        coldPoint.SetActive(true);
    }
}
