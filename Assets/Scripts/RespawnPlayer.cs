using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 spawnpoint;
    private GameObject Panel;
    private Rigidbody2D rb;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        spawnpoint = player.transform.position;
        Panel = GameObject.Find("TapToPlay");
        rb = GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Branch"))
        {
            player.transform.position = spawnpoint;
            Panel.SetActive(true);
            rb.simulated = false;
        }
    }
}