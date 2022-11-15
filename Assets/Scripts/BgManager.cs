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
    private float treeBGHorizontalPos;
    // Start is called before the first frame update
    void Start()
    {
        canopyBg.SetActive(false);
        forestBg.SetActive(false);
        treeTopsBg.SetActive(false);
        treeTrunksBg.SetActive(false);
        treeBGHorizontalPos = Random.Range(-1f, 1f);
        treeTopsBg.transform.position = new Vector3(treeBGHorizontalPos, 0, 0.5f);
        treeTrunksBg.transform.position = new Vector3(treeBGHorizontalPos, 0, 0.5f);
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
