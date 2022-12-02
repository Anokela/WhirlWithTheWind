using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgManager : MonoBehaviour
{
    public GameObject skyBg;
    public GameObject cloudsBg;
    public GameObject canopyBg;
    public GameObject forestBg;
    public GameObject treeTrunksBg;
    public GameObject skyToCanopyTrans;
    public GameObject canopyToForestTrans;
    private float treeBGHorizontalPos;
    public GameObject forestShinies;
    // Start is called before the first frame update
    void Start()
    {
        treeBGHorizontalPos = Random.Range(-1f, 1f);
        treeTrunksBg.transform.position = new Vector3(treeBGHorizontalPos, 0, 0.5f);
        skyBg.transform.position = new Vector3(treeBGHorizontalPos, 0, 1);
        canopyBg.transform.position = new Vector3(treeBGHorizontalPos, 0, 1);
        forestBg.transform.position = new Vector3(treeBGHorizontalPos, 0, 1);
        skyToCanopyTrans.transform.position = new Vector3(treeBGHorizontalPos, 0, 1);
        canopyToForestTrans.transform.position = new Vector3(treeBGHorizontalPos, 0, 1);
        forestShinies.transform.position = new Vector3(treeBGHorizontalPos, 0, 0.4f);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerInfo.Distance > 200)
        {
            skyToCanopyTrans.SetActive(true);
            skyBg.SetActive(false);
            canopyBg.SetActive(true);
        }
        
        if (PlayerInfo.Distance > 245)
        {
            skyToCanopyTrans.SetActive(false);
        }
        if (PlayerInfo.Distance > 375)
        {
            cloudsBg.SetActive(false);
        }
        if (PlayerInfo.Distance > 540)
        {
            
            canopyToForestTrans.SetActive(true);
            forestBg.SetActive(true);
            canopyBg.SetActive(false);
        }
        if (PlayerInfo.Distance > 590)
        {
            treeTrunksBg.SetActive(true);
            canopyToForestTrans.SetActive(false);
            forestShinies.SetActive(true);
        }
    }
}
