using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBehavior : MonoBehaviour
{
    private GameObject box;
    public float speed;
    // Start is called before the first frame update
    void Awake()
    {
        box = this.gameObject;
        Debug.Log(box);
    }

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        box.transform.Translate(Vector3.up * Time.deltaTime * speed);
        if(box.transform.position.y > 2)
        {
            box.SetActive(false);
        }
    }
}
