using UnityEngine;

public class OnDeathZoneCollide : MonoBehaviour
{
    public GameObject Panel;
    public GameObject pc;
    public GameObject manager;
    public GameObject counter;

    void Start()
    {
        Panel.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.CompareTag("Player"))
        {
            PlayerInfo.GameStarted = false;
            counter.SetActive(false);
            manager.SendMessage("OnApplicationQuit");
            Invoke("showPanel", 0);
            if (PlayerInfo.Distance > PlayerInfo.HighScore)
            {
                PlayerInfo.HighScore = PlayerInfo.Distance;
            }
        }
    }

    public void showPanel()
    {
        Panel.SetActive(true);
        pc.SetActive(false);
    }

    
}
