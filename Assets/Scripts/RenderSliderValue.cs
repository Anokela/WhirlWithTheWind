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
        if (masterSlider != null)
        {
            masterSlider.value = PlayerInfo.MasterVolume;
        }
        if (musicSlider != null)
        {
            musicSlider.value = PlayerInfo.MusicVolume;
        }
        if (sFXSlider != null)
        {
            sFXSlider.value = PlayerInfo.SFXVolume;
        }
    }
}
