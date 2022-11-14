using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgManager : MonoBehaviour
{
    public GameObject skyBg;
    public GameObject cloudsBg;
    public GameObject canopyBg;
    public GameObject forestBg;
    public GameObject treeTopsBg;
    public GameObject treeTrunksBg;
    // Start is called before the first frame update
    void Start()
    {
        canopyBg.SetActive(false);
        forestBg.SetActive(false);
        treeTopsBg.SetActive(false);
        treeTrunksBg.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerInfo.Distance > 15)
        {
            treeTopsBg.SetActive(true);

        }
        if (PlayerInfo.Distance > 100)
        {
            skyBg.SetActive(false);
            cloudsBg.SetActive(false);
            canopyBg.SetActive(true);
            treeTopsBg.SetActive(false);
            treeTrunksBg.SetActive(true);

        }
        if (PlayerInfo.Distance > 140)
        {
            canopyBg.SetActive(false);
            forestBg.SetActive(true);
        }
        if (PlayerInfo.Distance > 160)
        {
           
        }
    }
}
