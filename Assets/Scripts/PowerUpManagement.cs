using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManagement : MonoBehaviour
{
    // Start is called before the first frame update
    public int downDashPrice;
    public int upDashPrice;
    public int sideDashPrice;
    void Awake()
    {
        PowerUps.DownDashPrice = downDashPrice;
        PowerUps.UpDashPrice = upDashPrice;
        PowerUps.SideDashPrice = sideDashPrice;

    }
}
