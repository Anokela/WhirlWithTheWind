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
    public GameObject skyToCanopyTrans;
    public GameObject canopyToForestTrans;
    private float treeBGHorizontalPos;
    // Start is called before the first frame update
    void Start()
    {
        canopyBg.SetActive(false);
        forestBg.SetActive(false);
        treeTopsBg.SetActive(false);
        treeTrunksBg.SetActive(false);
        skyToCanopyTrans.SetActive(false);
        canopyToForestTrans.SetActive(false);
        treeBGHorizontalPos = Random.Range(-1f, 1f);
        treeTopsBg.transform.position = new Vector3(treeBGHorizontalPos, 0, 0.5f);
        treeTrunksBg.transform.position = new Vector3(treeBGHorizontalPos, 0, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerInfo.Distance > 15)
        {
            skyToCanopyTrans.SetActive(true);
            skyBg.SetActive(false);
        }
        if (PlayerInfo.Distance > 35)
        {
            cloudsBg.SetActive(false);
        }
        if (PlayerInfo.Distance > 54)
        {
            skyToCanopyTrans.SetActive(false);
            canopyBg.SetActive(true);
           // treeTrunksBg.SetActive(true);

        }
        if (PlayerInfo.Distance > 80)
        {
            treeTopsBg.SetActive(true);
            
            
        }
        if (PlayerInfo.Distance > 90)
        {
            canopyToForestTrans.SetActive(true);
            canopyBg.SetActive(false);
        }
        if (PlayerInfo.Distance > 155)
        {
            treeTrunksBg.SetActive(true);
            treeTopsBg.SetActive(false);
            forestBg.SetActive(true);
            canopyToForestTrans.SetActive(false);
        }
    }
}
