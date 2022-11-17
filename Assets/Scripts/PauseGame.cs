using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    private bool isTimeStopped;

    private void Start()
    {
        isTimeStopped = false;
    }
    public void Pause()
    {
        PlayerInfo.GameStarted = !PlayerInfo.GameStarted;
        isTimeStopped = !isTimeStopped;
    }

    private void Update()
    {
        if (isTimeStopped)
        {
            Time.timeScale = 0;
        } else
        {
            Time.timeScale = 1;
        }
    }
}
