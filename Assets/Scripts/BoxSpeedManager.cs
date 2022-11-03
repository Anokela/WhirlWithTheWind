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
        AccelerateBoxSpeed();
    }

    // Update is called once per frame
    private void AccelerateBoxSpeed()
    {
        if (PlayerInfo.BoxSpeed < 3)
        {
            PlayerInfo.BoxSpeed = PlayerInfo.BoxSpeed + 0.009f;
            Invoke("AccelerateBoxSpeed", 0.5f);
        }
    }
}
