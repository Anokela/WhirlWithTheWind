using UnityEngine;

public class EndlessPrefsManager : MonoBehaviour
{
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
        PlayerPrefs.Save();
    }
}
