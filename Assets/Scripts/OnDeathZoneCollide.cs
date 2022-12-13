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
    public GameObject newHighScoreImage;
    public GameObject fireWorksAnimation1;
    public GameObject fireWorksAnimation2;

    public void OnPlayerDeath()
    {
        PlayerInfo.HasPlayedSeedFall = 1;
        joystickProtector.SetActive(false);
        PlayerInfo.GameStarted = false;
        PlayerInfo.StopLoopingAudio = true;
        counter.SetActive(false);
        joystick.SetActive(false);
        Panel.SetActive(true);
        pc.SetActive(false);
        shopManager.SendMessage("SetShopButtonIcon");
        shopManager.SendMessage("SetPriceTexts");
        shopManager.SendMessage("IsSideDashPurchased");
        shopManager.SendMessage("IsUpDashPurchased");
        shopManager.SendMessage("IsDownDashPurchased");
        if (PlayerInfo.Distance > PlayerInfo.HighScore)
        {
            newHighScoreImage.SetActive(true);
            fireWorksAnimation1.SetActive(true);
            fireWorksAnimation2.SetActive(true);
            PlayerInfo.HighScore = PlayerInfo.Distance;
        }
        manager.SendMessage("SavePrefs");
        FirebaseAnalytics.LogEvent(name: "player_distance", parameterName: "distance_travelled", parameterValue: PlayerInfo.Distance);
        FirebaseAnalytics.LogEvent(name: "player_lightpoint_in_one_run", parameterName: "player_lightpoint_in_one_run", parameterValue: PlayerInfo.RunLightPoints);
    }
}
