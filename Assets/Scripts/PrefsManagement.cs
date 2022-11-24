using UnityEngine;
using UnityEngine.SceneManagement;

public class PrefsManagement : MonoBehaviour
{
    public bool resetPrefs = false;
    void Awake()
    {
        if (resetPrefs)
        {
            PlayerPrefs.DeleteKey("LightPoints");
            PlayerPrefs.DeleteKey("UpDashActive");
            PlayerPrefs.DeleteKey("DownDashActive");
            PlayerPrefs.DeleteKey("SideDashActive");
            // PlayerPrefs.SetInt("AntiBirdActive", 0);
            //PlayerPrefs.SetInt("AntiWebActive", 0);
            //PlayerPrefs.SetInt("CurrentSpawnPoint", 0);
            PlayerPrefs.DeleteKey("PowerUpsInUse");
            PlayerPrefs.DeleteKey("MasterVolume");
            PlayerPrefs.DeleteKey("MusicVolume");
            PlayerPrefs.DeleteKey("SFXVolume");
            PlayerPrefs.DeleteKey("HighScore");
            PlayerPrefs.DeleteKey("IsMasterMuted");
            PlayerPrefs.DeleteKey("IsMusicMuted");
            PlayerPrefs.DeleteKey("IsSFXMuted");
        }

        if (!PlayerPrefs.HasKey("LightPoints"))
        {
            PlayerPrefs.SetInt("LightPoints", 0);
        } 

        if (!PlayerPrefs.HasKey("UpDashActive"))
        {
            PlayerPrefs.SetInt("UpDashActive", 0);
        }

        if (!PlayerPrefs.HasKey("DownDashActive"))
        {
            PlayerPrefs.SetInt("DownDashActive", 0);
        }
        if (!PlayerPrefs.HasKey("SideDashActive"))
        {
            PlayerPrefs.SetInt("SideDashActive", 0);
        }
        if (!PlayerPrefs.HasKey("PowerUpsInUse"))
        {
            PlayerPrefs.SetInt("PowerUpsInUse", 0);
        }
        if (!PlayerPrefs.HasKey("MasterVolume"))
        {
            PlayerPrefs.SetFloat("MasterVolume", 1f);
        }
        if (!PlayerPrefs.HasKey("SFXVolume"))
        {
            PlayerPrefs.SetFloat("SFXVolume", 1f);
        }
        if (!PlayerPrefs.HasKey("MusicVolume"))
        {
            PlayerPrefs.SetFloat("MusicVolume", 1f);
        }
        if (!PlayerPrefs.HasKey("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", 1);
        }

        if (!PlayerPrefs.HasKey("IsMasterMuted"))
        {
            PlayerPrefs.SetInt("IsMasterMuted", 0);
        }

        if (!PlayerPrefs.HasKey("IsMusicMuted"))
        {
            PlayerPrefs.SetInt("IsMusicMuted", 0);
        }

        if (!PlayerPrefs.HasKey("IsSFXMuted"))
        {
            PlayerPrefs.SetInt("IsSFXMuted", 0);
        }


        PlayerInfo.UpDashActive = PlayerPrefs.GetInt("UpDashActive");
        PlayerInfo.DownDashActive = PlayerPrefs.GetInt("DownDashActive");
        PlayerInfo.SideDashActive = PlayerPrefs.GetInt("SideDashActive");
        // PlayerInfo.AntiBirdActive = PlayerPrefs.GetInt("AntiBirdActive");
        // PlayerInfo.AntiWebActive = PlayerPrefs.GetInt("AntiWebActive");
        // PlayerInfo.CurrentSpawnPoint = PlayerPrefs.GetInt("CurrentSpawnPoint");
        PlayerInfo.HighScore = PlayerPrefs.GetFloat("HighScore");
        PlayerInfo.PowerUpsInUse = PlayerPrefs.GetInt("PowerUpsInUse");
        PlayerInfo.MasterVolume = PlayerPrefs.GetFloat("MasterVolume");
        PlayerInfo.MusicVolume = PlayerPrefs.GetFloat("MusicVolume");
        PlayerInfo.SFXVolume = PlayerPrefs.GetFloat("SFXVolume");
        PlayerInfo.IsMasterMuted = PlayerPrefs.GetInt("IsMasterMuted");
        PlayerInfo.IsMusicMuted = PlayerPrefs.GetInt("IsMusicMuted");
        PlayerInfo.IsSFXMuted = PlayerPrefs.GetInt("IsSFXMuted");
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
        PlayerPrefs.SetInt("IsMasterMuted", PlayerInfo.IsMasterMuted);
        PlayerPrefs.SetInt("IsMusicMuted", PlayerInfo.IsMusicMuted);
        PlayerPrefs.SetInt("IsSFXMuted", PlayerInfo.IsSFXMuted);
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
        PlayerPrefs.SetInt("IsMasterMuted", PlayerInfo.IsMasterMuted);
        PlayerPrefs.SetInt("IsMusicMuted", PlayerInfo.IsMusicMuted);
        PlayerPrefs.SetInt("IsSFXMuted", PlayerInfo.IsSFXMuted);
        PlayerPrefs.Save();
    }
}
