using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DistanceCalculator : MonoBehaviour
{
    public TextMeshProUGUI distanceText;
    private float roundedDistance;
    public GameObject pc;
    // Update is called once per frame
    void Update()
    {
            distanceText.text = (10 * (PlayerInfo.Distance)).ToString("0");
    }
}
