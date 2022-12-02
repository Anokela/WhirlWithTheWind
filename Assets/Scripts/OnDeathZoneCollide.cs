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
    public GameObject shopManager;
    public GameObject joystickProtector;

    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.CompareTag("Player"))
        {
            joystickProtector.SetActive(false);
            PlayerInfo.GameStarted = false;
            PlayerInfo.StopLoopingAudio = true;
            counter.SetActive(false);
            joystick.SetActive(false);
            Invoke("showPanel", 0);
            shopManager.SendMessage("SetShopButtonIcon");
            shopManager.SendMessage("SetPriceTexts");
            //shopManager.SendMessage("AreButtonsInactive");
            shopManager.SendMessage("IsSideDashPurchased");
            shopManager.SendMessage("IsUpDashPurchased");
            shopManager.SendMessage("IsDownDashPurchased");
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
