using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPool : MonoBehaviour
{
    public static BoxPool SharedInstance;
    private List<GameObject> pool1;
    private List<GameObject> pool2;
    private List<GameObject> pool3;
    public List<GameObject> objectToPool1;
    public List<GameObject> objectToPool2;
    public List<GameObject> objectToPool3;
    private List<GameObject> freeObjects;

    private void Awake()
    {
        SharedInstance = this;
    }

    private void Start()
    {
        pool1 = new List<GameObject>();
        pool1 = GeneratePool(objectToPool1);
        pool2 = new List<GameObject>();
        pool2 = GeneratePool(objectToPool2);
        pool3 = new List<GameObject>();
        pool3 = GeneratePool(objectToPool3);
        freeObjects = new List<GameObject>();
    }

    public GameObject GetPooledObject()
    {
        freeObjects.Clear();
        int amountToPool;
        List<GameObject> poolToUse;
        

         if (PlayerInfo.Distance > 60f )
        {
            poolToUse = pool3;
            amountToPool = poolToUse.Count;
        }

        else if (PlayerInfo.Distance > 30f && PlayerInfo.Distance < 60f)
        {
            poolToUse = pool2;
            amountToPool = poolToUse.Count;
        }

        else
        {
            poolToUse = pool1;
            amountToPool = poolToUse.Count;
        }
        
        
        for(int i = 0; i < amountToPool; i++)
        {

            if (!poolToUse[i].activeInHierarchy)
            {
                freeObjects.Add(poolToUse[i]);
            }
        }
        int index = Random.Range(0, freeObjects.Count);
        return freeObjects[index];
    }

    private List<GameObject> GeneratePool(List<GameObject> list)
    {
        List<GameObject> pool;
        pool = new List<GameObject>(); 
        GameObject tmp;
        for(int i = 0; i<list.Count; i++)
        {
            tmp = Instantiate(list[i]);
            tmp.SetActive(false);
            pool.Add(tmp);
        }
        return pool;
    }
}
