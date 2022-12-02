using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseMenu;

    public void Pause()
    {
        if (PlayerInfo.GameStarted)
        {
            pauseMenu.SetActive(true);
            PlayerInfo.GameStarted = false;
        } 
    }

    public void UnPause()
    {
        pauseMenu.SetActive(false);
        PlayerInfo.GameStarted = true;
    }



    private void Update()
    {
        // Check if Back was pressed this frame
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }
}
