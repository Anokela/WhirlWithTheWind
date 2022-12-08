using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    public GameObject tutorialPanel;
    //public GameObject pcTutorial;
    public GameObject joystickTutorial;
    public GameObject creatureTutorial;
    public GameObject deathZoneTutorial;
    public GameObject lightPointTutorial;
    public GameObject goalTutorial;
    public GameObject tapToPlay;
    public GameObject JoystickProtector;
    public GameObject Joystick;
    private long currentTime;

    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if(scene.name == "Endless")
        {
            currentTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            if (PlayerInfo.IsSeedFallFreshStart == 1 || currentTime > PlayerInfo.LastPlayingTime + 2592000000)
            {
                tutorialPanel.SetActive(true);
                tapToPlay.SetActive(false);
                JoystickProtector.SetActive(false);
                Joystick.SetActive(false);
            }
        } 
    }
    public void showDeathZoneTutorial()
    {
        joystickTutorial.SetActive(false);
        deathZoneTutorial.SetActive(true);
    }
    public void showLightPointTutorial()
    {
        deathZoneTutorial.SetActive(false);
        lightPointTutorial.SetActive(true);
    }

    public void showCreatureTutorial()
    {
        lightPointTutorial.SetActive(false);
        creatureTutorial.SetActive(true);
    }
    public void showLastTutorial()
    {
        creatureTutorial.SetActive(false);
        goalTutorial.SetActive(true);
    }
    public void endTutorial()
    {
        tutorialPanel.SetActive(false);
        tapToPlay.SetActive(true);
        JoystickProtector.SetActive(true);
        Joystick.SetActive(true);
        PlayerInfo.IsSeedFallFreshStart = 0;
    }
    public void openMMTutorial()
    {
        joystickTutorial.SetActive(true);
        tutorialPanel.SetActive(true);
    }
    public void closeMMTutorial()
    {
        goalTutorial.SetActive(false);
        tutorialPanel.SetActive(false);
    }
}
