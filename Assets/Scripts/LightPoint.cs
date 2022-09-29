using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPoint : MonoBehaviour
{
    //Keep track of total picked lightPoints (Since the value is static, it can be accessed at "LightPoint.lightPoints" from any script)
    public static int lightPoints = 0;

    void Awake()
    {
        //Make Collider2D as trigger 
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
        //Destroy the ligtPoint if Object tagged Player comes in contact with it
        if (c2d.CompareTag("Player"))
        {
            //Add lightPoint to counter
            lightPoints++;
            //Test: Print total number of lightPoints
            // Debug.Log("You currently have " + LightPoint.lightPoints + " Light Points.");
            //Destroy lightPoint
            Destroy(gameObject);
            GameObject.Find("CM vcam1").SendMessage("HandleCalculation");
        }
    }
}
