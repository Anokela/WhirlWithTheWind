using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToPlay : MonoBehaviour
{
    private GameObject Panel;
    public GameObject pc;
    public GameObject speedManager;
    // Start is called before the first frame update
    void Start()
    {
        
        Time.timeScale = 0;
        Panel = GameObject.Find("TapToPlay");
       
    }

    public void StartScene()
    {
        speedManager.SendMessage("AccelerateBoxSpeed");
        PlayerInfo.RunLightPoints = 0;
        PlayerInfo.Distance = 0f; 
        PlayerInfo.BoxSpeed = 0.5f;
        Panel.SetActive(false);
        Time.timeScale = 1;
    }
}