using UnityEngine;
using Firebase.Analytics;

public class OnDeathZoneCollide : MonoBehaviour
{
    public GameObject Panel;
    public GameObject pc;
    public GameObject manager;
    public GameObject counter;
    public GameObject pauseBtn;

    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.CompareTag("Player"))
        {
            PlayerInfo.GameStarted = false;
            counter.SetActive(false);
            Invoke("showPanel", 0);
            if (PlayerInfo.Distance > PlayerInfo.HighScore)
            {
                PlayerInfo.HighScore = PlayerInfo.Distance;
            }
            manager.SendMessage("OnApplicationQuit");
               FirebaseAnalytics.LogEvent(name:"player_distance", parameterName:"distance_travelled", parameterValue: PlayerInfo.Distance);
            //FirepaseAnalytics.LogEvent(name: "Player_distance", params parameteres: new parameter(parameterName:"string", parameterValue: "Distance"));
        }
    }

    public void showPanel()
    {
        Panel.SetActive(true);
        pc.SetActive(false);
        pauseBtn.SetActive(false);
    }
}
