using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    private bool isTimeStopped;
    public GameObject pauseMenu;

    private void Start()
    {
        isTimeStopped = false;
    }
    public void Pause()
    {
        if (PlayerInfo.GameStarted)
        {
            pauseMenu.SetActive(true);
            PlayerInfo.GameStarted = false;
            isTimeStopped = true;
        } 
    }

    public void UnPause()
    {
        pauseMenu.SetActive(false);
        PlayerInfo.GameStarted = true;
        isTimeStopped = false;
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

        // Make sure user is on Android platform

            // Check if Back was pressed this frame
            if (Input.GetKeyDown(KeyCode.Escape))
            {

                // Quit the application
                Pause();
            }
    }
}
