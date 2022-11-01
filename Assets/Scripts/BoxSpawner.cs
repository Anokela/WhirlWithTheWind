using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UIElements;

public class BoxSpawner : MonoBehaviour
{
    private GameObject box;
    void Start()
    {
        box = BoxPool.SharedInstance.GetPooledObject();
        if (box != null)
        {
            box.transform.position = new Vector3(0f, 0f, 0f);
            box.SetActive(true);
        }
        GameObject box2 = BoxPool.SharedInstance.GetPooledObject();

        if (box2 != null)
        {
            box2.transform.position = new Vector3(0f, -2f, 0f);
            box2.SetActive(true);
        }
        CreateBox();
    }

    // Update is called once per frame
    public void CreateBox()
    {

        GameObject box2 = BoxPool.SharedInstance.GetPooledObject();
        if (box2 != null)
        {
            box2.transform.position = new Vector3(0f, -4f, 0f);
            box2.SetActive(true);
        }
        float spawnInterval = 4f;
        Invoke("CreateBox",spawnInterval);
    }
}
