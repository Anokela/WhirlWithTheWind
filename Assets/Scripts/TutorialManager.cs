using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TutorialManager : MonoBehaviour
{
    public GameObject tutorialPanel;
    public GameObject pcImg;
    public GameObject joystickImg;
    public GameObject goalText;
    public GameObject tapToPlay;
    private long currentTime;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
        if (PlayerInfo.IsSeedFallFreshStart == 1 || currentTime > PlayerInfo.LastPlayingTime + 2592000000)
        {
            tutorialPanel.SetActive(true);
            tapToPlay.SetActive(false);
        } 
    }

    public void showJoystickTutorial()
    {
        pcImg.SetActive(false);
        joystickImg.SetActive(true);
    }

    public void showGoalTutorial()
    {
        joystickImg.SetActive(false);
        goalText.SetActive(true);
    }

    public void endTutorial()
    {
        tutorialPanel.SetActive(false);
        tapToPlay.SetActive(true);
        PlayerInfo.IsSeedFallFreshStart = 0;
    }
}
