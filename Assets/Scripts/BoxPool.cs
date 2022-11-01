using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPool : MonoBehaviour
{
    public static BoxPool SharedInstance;
    public List<GameObject> pooledObjects;
    public List<GameObject> objectToPool;
    public List<GameObject> freeObjects;
    private int amountToPool;
    


    private void Awake()
    {
        SharedInstance = this;
    }

    private void Start()
    {

        int poolLength = objectToPool.Count;
        amountToPool = poolLength;
        pooledObjects = new List<GameObject>();
        freeObjects = new List<GameObject>();
        GameObject tmp;
        for(int i = 0; i < amountToPool; i++)
        {
            tmp = Instantiate(objectToPool[i]);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
        }
    }

    public GameObject GetPooledObject()
    {
        freeObjects.Clear();
        for(int i = 0; i < amountToPool; i++)
        {

            if (!pooledObjects[i].activeInHierarchy)
            {
                freeObjects.Add(pooledObjects[i]);
                
            }
        }
        int index = Random.Range(0, freeObjects.Count);
        return freeObjects[index];
    }
}
