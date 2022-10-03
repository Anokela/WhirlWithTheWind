using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToPlay : MonoBehaviour
{
    private GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        Panel = GameObject.Find("TapToPlay");
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartScene()
    {
        Time.timeScale = 1;
        Panel.SetActive(false);
    }
}
