using UnityEngine;
using Firebase.Analytics;

public class OnDeathZoneCollide : MonoBehaviour
{
    public GameObject Panel;
    public GameObject pc;
    public GameObject manager;
    public GameObject counter;
    public GameObject joystick;
    public GameObject shopButtonIconSetter;

    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.CompareTag("Player"))
        {
            PlayerInfo.GameStarted = false;
            shopButtonIconSetter.SendMessage("SetShopButtonIcon");
            counter.SetActive(false);
            joystick.SetActive(false);
            Invoke("showPanel", 0);
            if (PlayerInfo.Distance > PlayerInfo.HighScore)
            {
                PlayerInfo.HighScore = PlayerInfo.Distance;
            }
            manager.SendMessage("SavePrefs");
            FirebaseAnalytics.LogEvent(name:"player_distance", parameterName:"distance_travelled", parameterValue: PlayerInfo.Distance);
            FirebaseAnalytics.LogEvent(name: "player_lightpoint_in_one_run", parameterName: "player_lightpoint_in_one_run", parameterValue: PlayerInfo.RunLightPoints);
        }
    }

    public void showPanel()
    {
        Panel.SetActive(true);
        pc.SetActive(false);
    }
}
