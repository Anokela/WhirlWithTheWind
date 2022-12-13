using UnityEngine;
using System;

public class EndlessPrefsManager : MonoBehaviour
{
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
}
