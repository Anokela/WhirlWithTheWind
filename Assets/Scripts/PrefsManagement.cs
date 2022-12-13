using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class PrefsManagement : MonoBehaviour
{
    public bool resetPrefs = false;
    void Awake()
    {
        string sinceLastPlayed = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString();
        if (resetPrefs)
        {
            PlayerPrefs.DeleteKey("LightPoints");
            PlayerPrefs.DeleteKey("UpDashActive");
            PlayerPrefs.DeleteKey("DownDashActive");
            PlayerPrefs.DeleteKey("SideDashActive");
            PlayerPrefs.DeleteKey("AntiBirdActive");
            PlayerPrefs.DeleteKey("AntiWebActive");
            PlayerPrefs.DeleteKey("CurrentSpawnPoint");
            PlayerPrefs.DeleteKey("PowerUpsInUse");
            PlayerPrefs.DeleteKey("MasterVolume");
            PlayerPrefs.DeleteKey("MusicVolume");
            PlayerPrefs.DeleteKey("SFXVolume");
            PlayerPrefs.DeleteKey("HighScore");
            PlayerPrefs.DeleteKey("IsMasterMuted");
            PlayerPrefs.DeleteKey("IsMusicMuted");
            PlayerPrefs.DeleteKey("IsSFXMuted");
            PlayerPrefs.DeleteKey("PreviousMasterVolume");
            PlayerPrefs.DeleteKey("PreviousMusicVolume");
            PlayerPrefs.DeleteKey("PreviousSFXVolume");
            PlayerPrefs.DeleteKey("TimeSinceLastPlayOfSeedFall");
            PlayerPrefs.DeleteKey("HasPlayedSeedFall");
            PlayerPrefs.Save();
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
       /* if (!PlayerPrefs.HasKey("PowerUpsInUse"))
        {
            PlayerPrefs.SetInt("PowerUpsInUse", 0);
        }*/
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
            PlayerPrefs.SetFloat("HighScore", 0);
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

        if (!PlayerPrefs.HasKey("PreviousMasterVolume"))
        {
            PlayerPrefs.SetFloat("PreviousMasterVolume", 1f);
        }

        if (!PlayerPrefs.HasKey("PreviousMusicVolume"))
        {
            PlayerPrefs.SetFloat("PreviousMusicVolume", 1f);
        }

        if (!PlayerPrefs.HasKey("PreviousSFXVolume"))
        {
            PlayerPrefs.SetFloat("PreviousSFXVolume", 1f);
        }

        if (!PlayerPrefs.HasKey("TimeSinceLastPlayedSeedFall"))
        {
            PlayerPrefs.SetString("TimeSinceLastPlayedSeedFall", sinceLastPlayed);
        }

        if (!PlayerPrefs.HasKey("HasPlayedSeedFall"))
        {
            PlayerPrefs.SetInt("HasPlayedSeedFall", 0);
        }
        PlayerPrefs.Save();

        PlayerInfo.LightPoints = PlayerPrefs.GetInt("LightPoints");
        PlayerInfo.UpDashActive = PlayerPrefs.GetInt("UpDashActive");
        PlayerInfo.DownDashActive = PlayerPrefs.GetInt("DownDashActive");
        PlayerInfo.SideDashActive = PlayerPrefs.GetInt("SideDashActive");
        // PlayerInfo.AntiBirdActive = PlayerPrefs.GetInt("AntiBirdActive");
        // PlayerInfo.AntiWebActive = PlayerPrefs.GetInt("AntiWebActive");
        // PlayerInfo.CurrentSpawnPoint = PlayerPrefs.GetInt("CurrentSpawnPoint");
        PlayerInfo.HighScore = PlayerPrefs.GetFloat("HighScore");
        // PlayerInfo.PowerUpsInUse = PlayerPrefs.GetInt("PowerUpsInUse");
        PlayerInfo.MasterVolume = PlayerPrefs.GetFloat("MasterVolume");
        PlayerInfo.MusicVolume = PlayerPrefs.GetFloat("MusicVolume");
        PlayerInfo.SFXVolume = PlayerPrefs.GetFloat("SFXVolume");
        PlayerInfo.IsMasterMuted = PlayerPrefs.GetInt("IsMasterMuted");
        PlayerInfo.IsMusicMuted = PlayerPrefs.GetInt("IsMusicMuted");
        PlayerInfo.IsSFXMuted = PlayerPrefs.GetInt("IsSFXMuted");
        PlayerInfo.PreviousMasterVolume = PlayerPrefs.GetFloat("PreviousMasterVolume");
        PlayerInfo.PreviousMusicVolume = PlayerPrefs.GetFloat("PreviousMusicVolume");
        PlayerInfo.PreviousSFXVolume = PlayerPrefs.GetFloat("PreviousSFXVolume");
        long lng = Convert.ToInt64(PlayerPrefs.GetString("TimeSinceLastPlayedSeedFall"));
        PlayerInfo.LastPlayingTime = lng;
        PlayerInfo.HasPlayedSeedFall = PlayerPrefs.GetInt("HasPlayedSeedFall");

        if(PlayerInfo.HasPlayedSeedFall == 0)
        {
            ResetPrefs();
        }
    }

    // Update is called once per frame

    private void OnApplicationPause()
    {
        string sinceLastPlayed = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString();
        PlayerPrefs.SetInt("LightPoints", PlayerInfo.LightPoints);
        PlayerPrefs.SetInt("UpDashActive", PlayerInfo.UpDashActive);
        PlayerPrefs.SetInt("DownDashActive", PlayerInfo.DownDashActive);
        PlayerPrefs.SetInt("SideDashActive", PlayerInfo.SideDashActive);
        //PlayerPrefs.SetInt("AntiBirdActive", PlayerInfo.AntiBirdActive);
        //PlayerPrefs.SetInt("AntiWebActive", PlayerInfo.AntiWebActive);
        //PlayerPrefs.SetInt("CurrentSpawnPoint", PlayerInfo.CurrentSpawnPoint);
        PlayerPrefs.SetFloat("HighScore", PlayerInfo.HighScore);
        // PlayerPrefs.SetInt("PowerUpsInUse", PlayerInfo.PowerUpsInUse);
        PlayerPrefs.SetFloat("MasterVolume", PlayerInfo.MasterVolume);
        PlayerPrefs.SetFloat("MusicVolume", PlayerInfo.MusicVolume);
        PlayerPrefs.SetFloat("SFXVolume", PlayerInfo.SFXVolume);
        PlayerPrefs.SetInt("IsMasterMuted", PlayerInfo.IsMasterMuted);
        PlayerPrefs.SetInt("IsMusicMuted", PlayerInfo.IsMusicMuted);
        PlayerPrefs.SetInt("IsSFXMuted", PlayerInfo.IsSFXMuted);
        PlayerPrefs.SetFloat("PreviousMasterVolume", PlayerInfo.PreviousMasterVolume);
        PlayerPrefs.SetFloat("PreviousMusicVolume", PlayerInfo.PreviousMusicVolume);
        PlayerPrefs.SetFloat("PreviousSFXVolume", PlayerInfo.PreviousSFXVolume);
        PlayerPrefs.SetString("TimeSinceLastPlayedSeedFall", sinceLastPlayed);
        PlayerPrefs.SetInt("HasPlayedSeedFall", PlayerInfo.HasPlayedSeedFall);
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
        // PlayerPrefs.SetInt("PowerUpsInUse", PlayerInfo.PowerUpsInUse);
        PlayerPrefs.SetFloat("MasterVolume", PlayerInfo.MasterVolume);
        PlayerPrefs.SetFloat("MusicVolume", PlayerInfo.MusicVolume);
        PlayerPrefs.SetFloat("SFXVolume", PlayerInfo.SFXVolume);
        PlayerPrefs.SetInt("IsMasterMuted", PlayerInfo.IsMasterMuted);
        PlayerPrefs.SetInt("IsMusicMuted", PlayerInfo.IsMusicMuted);
        PlayerPrefs.SetInt("IsSFXMuted", PlayerInfo.IsSFXMuted);
        PlayerPrefs.SetFloat("PreviousMasterVolume", PlayerInfo.PreviousMasterVolume);
        PlayerPrefs.SetFloat("PreviousMusicVolume", PlayerInfo.PreviousMusicVolume);
        PlayerPrefs.SetFloat("PreviousSFXVolume", PlayerInfo.PreviousSFXVolume);
        PlayerPrefs.SetInt("HasPlayedSeedFall", PlayerInfo.HasPlayedSeedFall);
        PlayerPrefs.Save();
    }

    // This function is for testing with computer
    private void OnApplicationQuit()
    {
        string sinceLastPlayed = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString();
        PlayerPrefs.SetString("TimeSinceLastPlayedSeedFall", sinceLastPlayed);
        PlayerPrefs.SetInt("HasPlayedSeedFall", PlayerInfo.HasPlayedSeedFall);

    }

    public void ResetPrefs()
    {
        string sinceLastPlayed = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString();
        PlayerPrefs.SetInt("LightPoints", 0);
        PlayerPrefs.SetInt("UpDashActive", 0);
        PlayerPrefs.SetInt("DownDashActive", 0);
        PlayerPrefs.SetInt("SideDashActive", 0);
        PlayerPrefs.SetFloat("MasterVolume", 1f);
        PlayerPrefs.SetFloat("SFXVolume", 1f);
        PlayerPrefs.SetFloat("MusicVolume", 1f);
        PlayerPrefs.SetFloat("HighScore", 0);
        PlayerPrefs.SetInt("IsMasterMuted", 0);
        PlayerPrefs.SetInt("IsMusicMuted", 0);
        PlayerPrefs.SetInt("IsSFXMuted", 0);
        PlayerPrefs.SetFloat("PreviousMasterVolume", 1f);
        PlayerPrefs.SetFloat("PreviousMusicVolume", 1f);
        PlayerPrefs.SetFloat("PreviousSFXVolume", 1f);
        PlayerPrefs.SetString("TimeSinceLastPlayedSeedFall", sinceLastPlayed);
        PlayerPrefs.Save();

        PlayerInfo.LightPoints = PlayerPrefs.GetInt("LightPoints");
        PlayerInfo.UpDashActive = PlayerPrefs.GetInt("UpDashActive");
        PlayerInfo.DownDashActive = PlayerPrefs.GetInt("DownDashActive");
        PlayerInfo.SideDashActive = PlayerPrefs.GetInt("SideDashActive");
        PlayerInfo.HighScore = PlayerPrefs.GetFloat("HighScore");
        PlayerInfo.MasterVolume = PlayerPrefs.GetFloat("MasterVolume");
        PlayerInfo.MusicVolume = PlayerPrefs.GetFloat("MusicVolume");
        PlayerInfo.SFXVolume = PlayerPrefs.GetFloat("SFXVolume");
        PlayerInfo.IsMasterMuted = PlayerPrefs.GetInt("IsMasterMuted");
        PlayerInfo.IsMusicMuted = PlayerPrefs.GetInt("IsMusicMuted");
        PlayerInfo.IsSFXMuted = PlayerPrefs.GetInt("IsSFXMuted");
        PlayerInfo.PreviousMasterVolume = PlayerPrefs.GetFloat("PreviousMasterVolume");
        PlayerInfo.PreviousMusicVolume = PlayerPrefs.GetFloat("PreviousMusicVolume");
        PlayerInfo.PreviousSFXVolume = PlayerPrefs.GetFloat("PreviousSFXVolume");
        long lng = Convert.ToInt64(PlayerPrefs.GetString("TimeSinceLastPlayedSeedFall"));
        PlayerInfo.LastPlayingTime = lng;
    }
}
