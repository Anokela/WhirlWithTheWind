using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBehavior : MonoBehaviour
{
    private GameObject box;
    public float speed;
    private GameObject BoxSpawner;
    // Start is called before the first frame update
    void Awake()
    {
        BoxSpawner = GameObject.Find("BoxSpawner");
        box = this.gameObject;
        Debug.Log(box);
    }

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        box.transform.Translate(Vector3.up * Time.deltaTime * PlayerInfo.BoxSpeed);
        if(box.transform.position.y > 4)
        {
            box.SetActive(false);
            BoxSpawner.SendMessage("CreateBox");
        }
    }
}
