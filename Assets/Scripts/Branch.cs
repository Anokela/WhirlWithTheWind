using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Branch : MonoBehaviour
{
    private GameObject branch;
    private GameObject soundManager;

    private void Start()
    {
        soundManager = GameObject.Find("EndlessSoundManager");
        branch = this.gameObject;
    }

    void OnCollisionEnter2D(Collision2D c2d)
    {

        if (c2d.gameObject.tag == ("Player"))
        {

            soundManager.SendMessage("LeafSound");

        }
        
    }
}
