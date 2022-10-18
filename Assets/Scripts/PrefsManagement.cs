using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefsManagement : MonoBehaviour
{
    void Awake()
    {
        PlayerInfo.LightPoints = PlayerPrefs.GetInt("LightPoints");
        PlayerInfo.UpDashActive = PlayerPrefs.GetInt("UpDashActive");
    }

    // Update is called once per frame

    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
        PlayerPrefs.SetInt("LightPoints", PlayerInfo.LightPoints);
        PlayerPrefs.SetInt("UpDashActive", PlayerInfo.UpDashActive);
        PlayerPrefs.Save();
    }
}
