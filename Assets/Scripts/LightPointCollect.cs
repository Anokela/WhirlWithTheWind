using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPointCollect : MonoBehaviour
{
    private int lightPoints;
    // Start is called before the first frame update
    void Start()
    {
        lightPoints = -1;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(lightPoints);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Hep");
        Destroy(col.gameObject);
        lightPoints += 1; 
    }
}