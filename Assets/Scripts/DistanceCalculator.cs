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
        // roundedDistance = Mathf.Round(PlayerInfo.Distance * 100.0f) * 0.01f;
            distanceText.text = (10 * (PlayerInfo.Distance * PlayerInfo.BoxSpeed * 2)).ToString("0");
    }
    public void MeasureDistance()
    {
        PlayerInfo.Distance = Time.time * PlayerInfo.BoxSpeed;
        Invoke("MeasureDistance", 0.1f);
    }
}
