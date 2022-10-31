using UnityEngine.UI;
using UnityEngine;

public class ObstaclesCollideBehaviour : MonoBehaviour
{
    public GameObject player;
    public GameObject manager;
    private GameObject Panel;
    private Rigidbody2D rb;
    public Text ttp;

    private void Start()
    {
        Panel = GameObject.Find("TapToPlay");
        rb = GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Branch"))
        {
            manager.SendMessage("SpawnPlayer");
            Panel.SetActive(true);
            rb.simulated = false;
            ttp.SendMessage("StartBlinking");
        }
    }
}
