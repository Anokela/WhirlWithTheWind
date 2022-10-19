using UnityEngine;
using UnityEngine.UI;

public class RespawnPlayer : MonoBehaviour
{
    public GameObject player;
    // private Vector3 spawnpoint;
    private GameObject Panel;
    private Rigidbody2D rb;
    public Text ttp;
    public SpawnPoint[] levelSpawnPoints = new SpawnPoint[5];


    private void Awake()
    {
        if(player)
        {
            player.transform.position = (levelSpawnPoints[PlayerInfo.CurrentSpawnPoint].spawnPoint);
        }
        
    }
    private void Start()
    {
        Panel = GameObject.Find("TapToPlay");
        rb = GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Branch"))
        {
            Invoke("SpawnPlayer", 0);
            Panel.SetActive(true);
            rb.simulated = false;
            ttp.SendMessage("StartBlinking");
        }
    }

    void SpawnPlayer()
    {
        player.transform.position = levelSpawnPoints[PlayerInfo.CurrentSpawnPoint].spawnPoint;
    }
}