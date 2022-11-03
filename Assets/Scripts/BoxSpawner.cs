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
        CreateBox();
    }

    // Update is called once per frame
    public void CreateBox()
    {
        GameObject box2 = BoxPool.SharedInstance.GetPooledObject();
        box = BoxPool.SharedInstance.GetPooledObject();
        if (box != null)
        {
            box.transform.position = new Vector3(0f, -4f, 0f);
            box.SetActive(true);
        }
    }
}
