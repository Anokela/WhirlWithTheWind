using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RenderSliderValue : MonoBehaviour
{
    public Slider masterSlider;
    public Slider musicSlider;
    public Slider sFXSlider;
    // Start is called before the first frame update
    void Start()
    {
        masterSlider.value = PlayerInfo.MasterVolume;
        musicSlider.value = PlayerInfo.MusicVolume;
        sFXSlider.value = PlayerInfo.SFXVolume;
    }
}
