using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToPlay : MonoBehaviour
{
    private GameObject Panel;
    public GameObject pc;
    private Animator m_anim;
    public GameObject speedManager;
    public GameObject counter;
    // Start is called before the first frame update
    void Start()
    {
        m_anim = pc.GetComponent<Animator>();
        m_anim.enabled = false;
        PlayerInfo.GameStarted = false;
        PlayerInfo.RunLightPoints = 0;
        PlayerInfo.Distance = 0f;
        PlayerInfo.BoxSpeed = 0.5f;
        Panel = GameObject.Find("TapToPlay");
    }

    public void StartScene()
    {
        counter.SetActive(true);
        speedManager.SendMessage("AccelerateBoxSpeed");
        Panel.SetActive(false);
        m_anim.enabled = true;
        PlayerInfo.GameStarted = true;
    }
}