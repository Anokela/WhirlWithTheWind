using UnityEngine;
using UnityEngine.SceneManagement;

public class PrefsManagement : MonoBehaviour
{
    public bool resetPrefs = false;
    void Awake()
    {
        if (resetPrefs)
        {
            PlayerPrefs.SetInt("LightPoints", 0);
            PlayerPrefs.SetInt("UpDashActive", 0);
            PlayerPrefs.SetInt("DownDashActive", 0);
            PlayerPrefs.SetInt("SideDashActive", 0);
           // PlayerPrefs.SetInt("AntiBirdActive", 0);
            //PlayerPrefs.SetInt("AntiWebActive", 0);
            //PlayerPrefs.SetInt("CurrentSpawnPoint", 0);
            PlayerPrefs.SetInt("PowerUpsInUse", 0);
            PlayerPrefs.SetFloat("MasterVolume", 0.5f);
            PlayerPrefs.SetFloat("MusicVolume", 1f);
            PlayerPrefs.SetFloat("SFXVolume", 1f);
            PlayerPrefs.SetFloat("HighScore", 0);
            PlayerPrefs.Save();
        }

        if (PlayerPrefs.HasKey("LightPoints"))
        {
            PlayerInfo.LightPoints = PlayerPrefs.GetInt("LightPoints");
        } 
        else
        {
            PlayerInfo.LightPoints = 0;
        }

        if (PlayerPrefs.HasKey("UpDashActive"))
        {
            PlayerInfo.UpDashActive = PlayerPrefs.GetInt("UpDashActive");
        }
        else
        {
            PlayerInfo.UpDashActive = 0;
        }

        if (PlayerPrefs.HasKey("DownDashActive"))
        {
            PlayerInfo.DownDashActive = PlayerPrefs.GetInt("DownDashActive");
        }
        else
        {
            PlayerInfo.DownDashActive = 0;
        }

        if (PlayerPrefs.HasKey("SideDashActive"))
        {
            PlayerInfo.SideDashActive = PlayerPrefs.GetInt("SideDashActive");
        }
        else
        {
            PlayerInfo.SideDashActive = 0;
        }

        if (PlayerPrefs.HasKey("PowerUpsInUse"))
        {
            PlayerInfo.PowerUpsInUse = PlayerPrefs.GetInt("PowerUpsInUse");
        }
        else
        {
            PlayerInfo.PowerUpsInUse = 0;
        }

        if (PlayerPrefs.HasKey("MasterVolume"))
        {
            PlayerInfo.MasterVolume = PlayerPrefs.GetInt("MasterVolume");
        }
        else
        {
            PlayerInfo.MasterVolume = 0.5f;
        }

        if (PlayerPrefs.HasKey("SFXVolume"))
        {
            PlayerInfo.SFXVolume = PlayerPrefs.GetInt("SFXVolume");
        }
        else
        {
            PlayerInfo.SFXVolume = 1f;
        }
        
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            PlayerInfo.MusicVolume = PlayerPrefs.GetInt("MusicVolume");
        }
        else
        {
            PlayerInfo.MusicVolume = 1f;
        }

        if (PlayerPrefs.HasKey("HighScore"))
        {
            PlayerInfo.HighScore = PlayerPrefs.GetInt("HighScore");
        }
        else
        {
            PlayerInfo.HighScore = 0;
        }


        /*PlayerInfo.UpDashActive = PlayerPrefs.GetInt("UpDashActive");
        PlayerInfo.DownDashActive = PlayerPrefs.GetInt("DownDashActive");
        PlayerInfo.SideDashActive = PlayerPrefs.GetInt("SideDashActive");
        PlayerInfo.AntiBirdActive = PlayerPrefs.GetInt("AntiBirdActive");
        PlayerInfo.AntiWebActive = PlayerPrefs.GetInt("AntiWebActive");
        PlayerInfo.CurrentSpawnPoint = PlayerPrefs.GetInt("CurrentSpawnPoint");
        PlayerInfo.HighScore =  PlayerPrefs.GetFloat("HighScore");
        PlayerInfo.PowerUpsInUse = PlayerPrefs.GetInt("PowerUpsInUse");
        PlayerInfo.MasterVolume = PlayerPrefs.GetFloat("MasterVolume");
        PlayerInfo.MusicVolume = PlayerPrefs.GetFloat("MusicVolume");
        PlayerInfo.SFXVolume = PlayerPrefs.GetFloat("SFXVolume");*/
    }

    // Update is called once per frame

    private void OnApplicationPause()
    {
        PlayerPrefs.SetInt("LightPoints", PlayerInfo.LightPoints);
        PlayerPrefs.SetInt("UpDashActive", PlayerInfo.UpDashActive);
        PlayerPrefs.SetInt("DownDashActive", PlayerInfo.DownDashActive);
        PlayerPrefs.SetInt("SideDashActive", PlayerInfo.SideDashActive);
        //PlayerPrefs.SetInt("AntiBirdActive", PlayerInfo.AntiBirdActive);
        //PlayerPrefs.SetInt("AntiWebActive", PlayerInfo.AntiWebActive);
        //PlayerPrefs.SetInt("CurrentSpawnPoint", PlayerInfo.CurrentSpawnPoint);
        PlayerPrefs.SetFloat("HighScore", PlayerInfo.HighScore);
        PlayerPrefs.SetInt("PowerUpsInUse", PlayerInfo.PowerUpsInUse);
        PlayerPrefs.SetFloat("MasterVolume", PlayerInfo.MasterVolume);
        PlayerPrefs.SetFloat("MusicVolume", PlayerInfo.MusicVolume);
        PlayerPrefs.SetFloat("SFXVolume", PlayerInfo.SFXVolume);
        PlayerPrefs.Save();
    }

    private void SavePrefs()
    {
        PlayerPrefs.SetInt("LightPoints", PlayerInfo.LightPoints);
        PlayerPrefs.SetInt("UpDashActive", PlayerInfo.UpDashActive);
        PlayerPrefs.SetInt("DownDashActive", PlayerInfo.DownDashActive);
        PlayerPrefs.SetInt("SideDashActive", PlayerInfo.SideDashActive);
        //PlayerPrefs.SetInt("AntiBirdActive", PlayerInfo.AntiBirdActive);
        //PlayerPrefs.SetInt("AntiWebActive", PlayerInfo.AntiWebActive);
        //PlayerPrefs.SetInt("CurrentSpawnPoint", PlayerInfo.CurrentSpawnPoint);
        PlayerPrefs.SetFloat("HighScore", PlayerInfo.HighScore);
        PlayerPrefs.SetInt("PowerUpsInUse", PlayerInfo.PowerUpsInUse);
        PlayerPrefs.SetFloat("MasterVolume", PlayerInfo.MasterVolume);
        PlayerPrefs.SetFloat("MusicVolume", PlayerInfo.MusicVolume);
        PlayerPrefs.SetFloat("SFXVolume", PlayerInfo.SFXVolume);
        PlayerPrefs.Save();
    }
}
