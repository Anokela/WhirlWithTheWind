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
            PlayerPrefs.SetInt("AntiBirdActive", 0);
            PlayerPrefs.SetInt("AntiWebActive", 0);
            PlayerPrefs.SetInt("CurrentSpawnPoint", 0);
            PlayerPrefs.SetInt("PowerUpsInUse", 0);
            //PlayerPrefs.SetFloat("HighScore", 0);
            PlayerPrefs.Save();
        }
        PlayerInfo.LightPoints = PlayerPrefs.GetInt("LightPoints");
        PlayerInfo.UpDashActive = PlayerPrefs.GetInt("UpDashActive");
        PlayerInfo.DownDashActive = PlayerPrefs.GetInt("DownDashActive");
        PlayerInfo.SideDashActive = PlayerPrefs.GetInt("SideDashActive");
        PlayerInfo.AntiBirdActive = PlayerPrefs.GetInt("AntiBirdActive");
        PlayerInfo.AntiWebActive = PlayerPrefs.GetInt("AntiWebActive");
        PlayerInfo.CurrentSpawnPoint = PlayerPrefs.GetInt("CurrentSpawnPoint");
        PlayerInfo.HighScore =  PlayerPrefs.GetFloat("HighScore");
        PlayerInfo.PowerUpsInUse = PlayerPrefs.GetInt("PowerUpsInUse");
    }

    // Update is called once per frame

    private void OnApplicationPause()
    {
        PlayerPrefs.SetInt("LightPoints", PlayerInfo.LightPoints);
        PlayerPrefs.SetInt("UpDashActive", PlayerInfo.UpDashActive);
        PlayerPrefs.SetInt("DownDashActive", PlayerInfo.DownDashActive);
        PlayerPrefs.SetInt("SideDashActive", PlayerInfo.SideDashActive);
        PlayerPrefs.SetInt("AntiBirdActive", PlayerInfo.AntiBirdActive);
        PlayerPrefs.SetInt("AntiWebActive", PlayerInfo.AntiWebActive);
        PlayerPrefs.SetInt("CurrentSpawnPoint", PlayerInfo.CurrentSpawnPoint);
        PlayerPrefs.SetFloat("HighScore", PlayerInfo.HighScore);
        PlayerPrefs.SetInt("PowerUpsInUse", PlayerInfo.PowerUpsInUse);
        PlayerPrefs.Save();
    }

    private void SavePrefs()
    {
        PlayerPrefs.SetInt("LightPoints", PlayerInfo.LightPoints);
        PlayerPrefs.SetInt("UpDashActive", PlayerInfo.UpDashActive);
        PlayerPrefs.SetInt("DownDashActive", PlayerInfo.DownDashActive);
        PlayerPrefs.SetInt("SideDashActive", PlayerInfo.SideDashActive);
        PlayerPrefs.SetInt("AntiBirdActive", PlayerInfo.AntiBirdActive);
        PlayerPrefs.SetInt("AntiWebActive", PlayerInfo.AntiWebActive);
        PlayerPrefs.SetInt("CurrentSpawnPoint", PlayerInfo.CurrentSpawnPoint);
        PlayerPrefs.SetFloat("HighScore", PlayerInfo.HighScore);
        PlayerPrefs.SetInt("PowerUpsInUse", PlayerInfo.PowerUpsInUse);
        PlayerPrefs.Save();
    }

    public void ResetPrefs()
    {
        PlayerPrefs.SetInt("LightPoints", 0);
        PlayerPrefs.SetInt("UpDashActive", 0);
        PlayerPrefs.SetInt("DownDashActive", 0);
        PlayerPrefs.SetInt("SideDashActive", 0);
        PlayerPrefs.SetInt("AntiBirdActive", 0);
        PlayerPrefs.SetInt("AntiWebActive", 0);
        PlayerPrefs.SetInt("CurrentSpawnPoint", 0);
        PlayerPrefs.SetFloat("HighScore", 0);
        PlayerPrefs.SetInt("PowerUpsInUse", 0);
        PlayerPrefs.Save();
        // SceneManager.LoadScene("Level1");
    }
}
