using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgManager : MonoBehaviour
{
    public GameObject skyBg;
    public GameObject cloudsBg;
    public GameObject canopyBg;
    public GameObject forestBg;
    // Start is called before the first frame update
    void Start()
    {
        canopyBg.SetActive(false);
        forestBg.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerInfo.Distance > 25)
        {
            skyBg.SetActive(false);
            cloudsBg.SetActive(false);
            canopyBg.SetActive(true);
        }
        if (PlayerInfo.Distance > 50)
        {
            canopyBg.SetActive(false);
            forestBg.SetActive(true);
        }
    }
}
