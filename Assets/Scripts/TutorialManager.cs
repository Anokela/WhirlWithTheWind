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
    private AudioSource audioSrc;
    public AudioClip buttonSound;
    public GameObject buttonSoundManager;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = buttonSoundManager.GetComponent<AudioSource>();
        Scene scene = SceneManager.GetActiveScene();
        if(scene.name == "Endless")
        {
            currentTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            if (PlayerInfo.IsSeedFallFreshStart == 0 || currentTime > PlayerInfo.LastPlayingTime + 2592000000)
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
        audioSrc.PlayOneShot(buttonSound);
        joystickTutorial.SetActive(false);
        deathZoneTutorial.SetActive(true);
    }
    public void showLightPointTutorial()
    {
        audioSrc.PlayOneShot(buttonSound);
        deathZoneTutorial.SetActive(false);
        lightPointTutorial.SetActive(true);
    }

    public void showCreatureTutorial()
    {
        audioSrc.PlayOneShot(buttonSound);
        lightPointTutorial.SetActive(false);
        creatureTutorial.SetActive(true);
    }
    public void showLastTutorial()
    {
        audioSrc.PlayOneShot(buttonSound);
        creatureTutorial.SetActive(false);
        goalTutorial.SetActive(true);
    }
    public void endTutorial()
    {
        audioSrc.PlayOneShot(buttonSound);
        tutorialPanel.SetActive(false);
        tapToPlay.SetActive(true);
        JoystickProtector.SetActive(true);
        Joystick.SetActive(true);
    }
    public void openMMTutorial()
    {
        audioSrc.PlayOneShot(buttonSound);
        joystickTutorial.SetActive(true);
        tutorialPanel.SetActive(true);
    }
    public void closeMMTutorial()
    {
        audioSrc.PlayOneShot(buttonSound);
        goalTutorial.SetActive(false);
        tutorialPanel.SetActive(false);
    }
}
