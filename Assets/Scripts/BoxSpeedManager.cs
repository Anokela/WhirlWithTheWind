using UnityEngine;

public class BoxSpeedManager : MonoBehaviour
{
    public void AccelerateBoxSpeed()
    {
        if (PlayerInfo.BoxSpeed < 2)
        {
            PlayerInfo.BoxSpeed = PlayerInfo.BoxSpeed + 0.00095f;
            Invoke("AccelerateBoxSpeed", 0.4f);
        }
    }
}
