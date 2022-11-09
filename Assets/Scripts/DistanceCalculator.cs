using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DistanceCalculator : MonoBehaviour
{
    public TextMeshProUGUI distanceText;
    public GameObject pc;
    private float timer;
    private void Start()
    {
        timer = 0;
    }
    // Update is called once per frame
    void Update()
    {
        distanceText.text = PlayerInfo.Distance.ToString("0");
    }

    private void FixedUpdate()
    {
        if (PlayerInfo.GameStarted)
        {
            timer = timer + Time.fixedDeltaTime*3;
            // PlayerInfo.Distance = Mathf.Round(10 * (PlayerInfo.BoxSpeed * Time.timeSinceLevelLoad));
            PlayerInfo.Distance = Mathf.Round(PlayerInfo.BoxSpeed * timer);
        }
    }
}
