using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPoint : MonoBehaviour
{
    public int index;
    // private GameObject manager;
    public LightPointManager manager;
    private GameObject mng;
    private GameObject lightPoint;
    void Awake()
    {
        //Make Collider2D as trigger 
        GetComponent<Collider2D>().isTrigger = true;
        mng = GameObject.Find("LightPointManager");
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
            Debug.Log("Index is " + index);
            //Add lightPoint to counter
            PlayerInfo.LightPoints++;
            //Destroy lightPoint
            // manager.LevelLightPoints[index].isCollected = true;
            lightPoint.SetActive(false);
            // manager.SendMessage("HandleCalculation");
            mng.SendMessage("HandleCalculation");
            Invoke("ActivateLightPoint", 4/PlayerInfo.BoxSpeed);
        }
    }

    void ActivateLightPoint ()
    {
        lightPoint.SetActive(true);
    }
}
