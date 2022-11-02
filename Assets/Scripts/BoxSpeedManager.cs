using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpeedManager : MonoBehaviour
{

    public float speed = 1.5f;

    void Awake()
    {
        PlayerInfo.BoxSpeed = speed;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerInfo.BoxSpeed < 3)
        {
            PlayerInfo.BoxSpeed = PlayerInfo.BoxSpeed * 1.0001f;
        }
       
    }
}
