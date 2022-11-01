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
            PlayerPrefs.Save();
        }
        PlayerInfo.LightPoints = PlayerPrefs.GetInt("LightPoints");
        PlayerInfo.UpDashActive = PlayerPrefs.GetInt("UpDashActive");
        PlayerInfo.DownDashActive = PlayerPrefs.GetInt("DownDashActive");
        PlayerInfo.SideDashActive = PlayerPrefs.GetInt("SideDashActive");
        PlayerInfo.AntiBirdActive = PlayerPrefs.GetInt("AntiBirdActive");
        PlayerInfo.AntiWebActive = PlayerPrefs.GetInt("AntiWebActive");
        PlayerInfo.CurrentSpawnPoint = PlayerPrefs.GetInt("CurrentSpawnPoint");
        Debug.Log(PlayerInfo.CurrentSpawnPoint);
    }

    // Update is called once per frame

    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
        PlayerPrefs.SetInt("LightPoints", PlayerInfo.LightPoints);
        PlayerPrefs.SetInt("UpDashActive", PlayerInfo.UpDashActive);
        PlayerPrefs.SetInt("DownDashActive", PlayerInfo.DownDashActive);
        PlayerPrefs.SetInt("SideDashActive", PlayerInfo.SideDashActive);
        PlayerPrefs.SetInt("AntiBirdActive", PlayerInfo.AntiBirdActive);
        PlayerPrefs.SetInt("AntiWebActive", PlayerInfo.AntiWebActive);
        PlayerPrefs.SetInt("CurrentSpawnPoint", PlayerInfo.CurrentSpawnPoint);
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
        PlayerPrefs.Save();
        // SceneManager.LoadScene("Level1");
    }
}
