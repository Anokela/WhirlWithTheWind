
using UnityEngine;

public class PlayerSpawnManager : MonoBehaviour
{
    public GameObject player;
    public SpawnPoint[] levelSpawnPoints = new SpawnPoint[5];

    void Start()
    {
        // Debug.Log(PlayerInfo.CurrentSpawnPoint);
        Debug.Log("SpawnPoint: " + levelSpawnPoints[PlayerInfo.CurrentSpawnPoint].spawnPoint);
        if (player)
        {
            player.transform.position = (levelSpawnPoints[PlayerInfo.CurrentSpawnPoint].spawnPoint);
        }

    }

    void SpawnPlayer()
    {
        player.transform.position = levelSpawnPoints[PlayerInfo.CurrentSpawnPoint].spawnPoint;
    }
}
