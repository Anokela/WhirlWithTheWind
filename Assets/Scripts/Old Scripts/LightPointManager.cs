using System.Collections.Generic;
using UnityEngine;

public class LightPointManager : MonoBehaviour
{
    public LightPointCollectable[] LevelLightPoints = new LightPointCollectable[300];
    public GameObject lp;
    public static LightPointManager lightPointManager;

    // Start is called before the first frame update
    void Start()
    {
        if (!lightPointManager)
        {
            lightPointManager = this;
        }

        int i = 0;
        foreach(LightPointCollectable lightPoint in LevelLightPoints)
        {
            if (!lightPoint.isCollected)
            {
                GameObject point = Instantiate(lp, lightPoint.position, Quaternion.identity);
                LightPoint script = point.GetComponent<LightPoint>();
               /* script.index = i;
                script.manager = this;*/
            }
            i++;
        }
    }
}
