using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MMSoundManager : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider masterSlider;
    public Slider musicSlider;
    public Slider sFXSlider;
    public Image masterMuteIcon;
    public Image musicMuteIcon;
    public Image sFXMuteIcon;
    public Sprite mutedIcon;
    public Sprite unMutedIcon;

    void Start()
    {
        RenderVolume();
    }

    void FixedUpdate()
    {
        if (PlayerInfo.IsMasterMuted == 0)
        {
            audioMixer.SetFloat("MasterVol", Mathf.Log10(PlayerInfo.MasterVolume) * 20);
            PlayerInfo.PreviousMasterVolume = PlayerInfo.MasterVolume;
        } else
        {
            audioMixer.SetFloat("MasterVol", Mathf.Log10(0.0001f) * 20);
        }

        if (PlayerInfo.IsMusicMuted == 0)
        {
            audioMixer.SetFloat("MusicVol", Mathf.Log10(PlayerInfo.MusicVolume) * 20);
            PlayerInfo.PreviousMusicVolume = PlayerInfo.MusicVolume;
        } else
        {
            audioMixer.SetFloat("MusicVol", Mathf.Log10(0.0001f) * 20);
        }

        if (PlayerInfo.IsSFXMuted == 0)
        {
            audioMixer.SetFloat("SFXVol", Mathf.Log10(PlayerInfo.SFXVolume) * 20);
            PlayerInfo.PreviousSFXVolume = PlayerInfo.SFXVolume;
        } else
        {
            audioMixer.SetFloat("SFXVol", Mathf.Log10(0.0001f) * 20);
        }

        // Mute Icon change based on volume
        if (PlayerInfo.MasterVolume > 0.0001f)
        {
            masterMuteIcon.sprite = unMutedIcon;
        } else
        {
            masterMuteIcon.sprite = mutedIcon;
        }

        if (PlayerInfo.MusicVolume > 0.0001f)
        {
            musicMuteIcon.sprite = unMutedIcon;
        }
        else
        {
            musicMuteIcon.sprite = mutedIcon;
        }

        if (PlayerInfo.SFXVolume > 0.0001f)
        {
            sFXMuteIcon.sprite = unMutedIcon;
        }
        else
        {
            sFXMuteIcon.sprite = mutedIcon;
        }
    }

    // uses slider value from UI to set volume level
    public void SetMasterLevel(float sliderValue)
    {
 
        PlayerInfo.MasterVolume = sliderValue;

        if(sliderValue > 0.0001f)
        {
            PlayerInfo.IsMasterMuted = 0;
        }
       
    }

    public void SetMusicLevel(float sliderValue)
    {
        PlayerInfo.MusicVolume = sliderValue;
        if (sliderValue > 0.0001f)
        {
            PlayerInfo.IsMusicMuted = 0;
        }
    }
    public void SetSFXLevel(float sliderValue)
    {
        PlayerInfo.SFXVolume = sliderValue;
        if (sliderValue > 0.0001f)
        {
            PlayerInfo.IsSFXMuted = 0;
        }
    }

    // mute/unmute channels
    public void MuteMaster()
    {
        switch(PlayerInfo.IsMasterMuted) {
            case 0:
                PlayerInfo.IsMasterMuted = 1;
                break;
            case 1:
                PlayerInfo.IsMasterMuted = 0;
                PlayerInfo.MasterVolume = PlayerInfo.PreviousMasterVolume;
                break;
        }
        RenderVolume();
    }
    public void MuteMusic()
    {
        switch (PlayerInfo.IsMusicMuted)
        {
            case 0:
                PlayerInfo.IsMusicMuted = 1;
                break;
            case 1:
                PlayerInfo.IsMusicMuted = 0;
                PlayerInfo.MusicVolume = PlayerInfo.PreviousMusicVolume;
                break;
        }
        RenderVolume();
    }
    public void MuteSFX()
    {
        switch (PlayerInfo.IsSFXMuted)
        {
            case 0:
                PlayerInfo.IsSFXMuted = 1;
                break;
            case 1:
                PlayerInfo.IsSFXMuted = 0;
                PlayerInfo.SFXVolume = PlayerInfo.PreviousSFXVolume;
                break;
        }
        RenderVolume();
    }

    // Render the sliders to show current volume
    public void RenderVolume()
    {
        if (PlayerInfo.IsMasterMuted == 0)
        {
            masterSlider.value = PlayerInfo.MasterVolume;
        }
        else
        {
            masterSlider.value = 0.0001f;
        }

        if (PlayerInfo.IsMusicMuted == 0)
        {
            musicSlider.value = PlayerInfo.MusicVolume;
        }
        else
        {
            musicSlider.value = 0.0001f;
        }

        if (PlayerInfo.IsSFXMuted == 0)
        {
            sFXSlider.value = PlayerInfo.SFXVolume;
        }
        else
        {
            sFXSlider.value = 0.0001f;
        }
    }
}
