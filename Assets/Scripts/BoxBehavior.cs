using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBehavior : MonoBehaviour
{
    private GameObject box;
    private GameObject BoxSpawner;
    // Start is called before the first frame update
    void Awake()
    {
        BoxSpawner = GameObject.Find("BoxSpawner");
        box = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerInfo.GameStarted)
        {
            box.transform.Translate(Vector3.up * 0.004f * PlayerInfo.BoxSpeed);
            if (box.transform.position.y > 4)
            {
                box.SetActive(false);
                BoxSpawner.SendMessage("CreateBox");
            }
        }
    }
}
