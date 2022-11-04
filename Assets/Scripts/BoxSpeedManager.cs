using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpeedManager : MonoBehaviour
{

    public static float speed = 1.5f;

    void Awake()
    {
        PlayerInfo.BoxSpeed = speed;
    }
    // Start is called before the first frame update

    // Update is called once per frame
    public void AccelerateBoxSpeed()
    {
        if (PlayerInfo.BoxSpeed < 2)
        {
            PlayerInfo.BoxSpeed = PlayerInfo.BoxSpeed + 0.001f;
            Invoke("AccelerateBoxSpeed", 0.5f);
        }
    }
}
