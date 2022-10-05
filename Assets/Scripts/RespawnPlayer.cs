using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 spawnpoint;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        spawnpoint = player.transform.position;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Branch"))
        {
            player.transform.position = spawnpoint;
        }
    }
}