using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MMSoundManager : MonoBehaviour
{
    public AudioMixer audioMixer;
    void FixedUpdate()
    {
        audioMixer.SetFloat("MasterVol", Mathf.Log10(PlayerInfo.MasterVolume) * 20);
        audioMixer.SetFloat("MusicVol", Mathf.Log10(PlayerInfo.MusicVolume) * 20);
        audioMixer.SetFloat("SFXVol", Mathf.Log10(PlayerInfo.SFXVolume) * 20);
    }

    public void SetMasterLevel(float sliderValue)
    {
        PlayerInfo.MasterVolume = sliderValue;
    }
    public void SetMusicLevel(float sliderValue)
    {
        PlayerInfo.MusicVolume = sliderValue;
    }
    public void SetSFXLevel(float sliderValue)
    {
        PlayerInfo.SFXVolume = sliderValue;
    }
}
