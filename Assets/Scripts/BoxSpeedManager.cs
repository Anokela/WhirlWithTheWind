using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpeedManager : MonoBehaviour
{
    // Update is called once per frame
    public void AccelerateBoxSpeed()
    {
        if (PlayerInfo.BoxSpeed < 2)
        {
            //PlayerInfo.BoxSpeed = PlayerInfo.BoxSpeed + 0.00075f;
            PlayerInfo.BoxSpeed = PlayerInfo.BoxSpeed + 0.1f;
            Invoke("AccelerateBoxSpeed", 0.5f);
        }
    }
}
