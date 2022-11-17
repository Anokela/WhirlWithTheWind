using UnityEngine;

public class EndlessPrefsManager : MonoBehaviour
{
    private void OnApplicationQuit()
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
}
