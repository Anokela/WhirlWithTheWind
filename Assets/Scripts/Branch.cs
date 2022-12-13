using UnityEngine;

public class Branch : MonoBehaviour
{
    private GameObject branch;
    private GameObject soundManager;
    private bool soundShouldStop;

    private void Start()
    {
        soundManager = GameObject.Find("EndlessSoundManager");
        branch = this.gameObject;
    }
    void OnCollisionEnter2D(Collision2D c2d)
    {
        if (c2d.gameObject.tag == ("Player"))
        {
            soundManager.SendMessage("LeafSound");
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        soundShouldStop = true;
    }

    private void FixedUpdate()
    {
        if (soundShouldStop)
        {
            soundManager.SendMessage("StopLeavesSound");
            soundShouldStop = false;
        }
    }
}
