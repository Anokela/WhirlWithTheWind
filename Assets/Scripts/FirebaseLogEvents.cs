using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Analytics;

public class FirebaseLogEvents : MonoBehaviour
{
    private bool hasLogged10
    private bool hasLogged25;
    private bool hasLogged50;
    private bool hasLogged75;
    private bool hasLogged100;
    private bool hasLogged125;
    private bool hasLogged150;
    private bool hasLogged200;
    private bool hasLogged250;
    private bool hasLogged300;
    private bool hasLogged500;
    private bool hasLogged750;
    private bool hasLogged1000;
    
    
    void Start()
    {
        hasLogged10 = false;
        hasLogged25 = false;
        hasLogged50 = false;
        hasLogged75 = false;
        hasLogged100 = false;
        hasLogged125 = false;
        hasLogged150 = false;
        hasLogged200 = false;
        hasLogged250 = false;
        hasLogged300 = false;
        hasLogged500 = false;
        hasLogged750 = false;
        hasLogged1000 = false;
    }

    void FixedUpdate()
    {
        if(PlayerInfo.Distance >= 10 && !hasLogged10)
         {
            FirebaseAnalytics.LogEvent(name:"player_distance10", parameterName:"travelled10", parameterValue: PlayerInfo.Distance);
             hasLogged10 = true;
        }
            if(PlayerInfo.Distance >= 25 && !hasLogged25)
         {
            FirebaseAnalytics.LogEvent(name:"player_distance25", parameterName:"travelled25", parameterValue: PlayerInfo.Distance);
             hasLogged25 = true;
        }
            if(PlayerInfo.Distance >= 50 && !hasLogged50)
         {
            FirebaseAnalytics.LogEvent(name:"player_distance50", parameterName:"travelled50", parameterValue: PlayerInfo.Distance);
             hasLogged50 = true;
        }
            if(PlayerInfo.Distance >= 75 && !hasLogged75)
         {
            FirebaseAnalytics.LogEvent(name:"player_distance75", parameterName:"travelled75", parameterValue: PlayerInfo.Distance);
             hasLogged75 = true;
        }
            if(PlayerInfo.Distance >= 100 && !hasLogged100)
         {
            FirebaseAnalytics.LogEvent(name:"player_distance100", parameterName:"travelled100", parameterValue: PlayerInfo.Distance);
             hasLogged100 = true;
        }
            if(PlayerInfo.Distance >= 125 && !hasLogged125)
         {
            FirebaseAnalytics.LogEvent(name:"player_distance125", parameterName:"travelled125", parameterValue: PlayerInfo.Distance);
             hasLogged125 = true;
        }
            if(PlayerInfo.Distance >= 150 && !hasLogged150)
         {
            FirebaseAnalytics.LogEvent(name:"player_distance150", parameterName:"travelled150", parameterValue: PlayerInfo.Distance);
             hasLogged150 = true;
        }
            if(PlayerInfo.Distance >= 200 && !hasLogged200)
         {
            FirebaseAnalytics.LogEvent(name:"player_distance200", parameterName:"travelled200", parameterValue: PlayerInfo.Distance);
             hasLogged200 = true;
        }
            if(PlayerInfo.Distance >= 250 && !hasLogged250)
         {
            FirebaseAnalytics.LogEvent(name:"player_distance250", parameterName:"travelled250", parameterValue: PlayerInfo.Distance);
             hasLogged250 = true;
        }
            if(PlayerInfo.Distance >= 300 && !hasLogged300)
         {
            FirebaseAnalytics.LogEvent(name:"player_distance300", parameterName:"travelled300", parameterValue: PlayerInfo.Distance);
             hasLogged300 = true;
        }
            if(PlayerInfo.Distance >= 500 && !hasLogged500)
         {
            FirebaseAnalytics.LogEvent(name:"player_distance500", parameterName:"travelled500", parameterValue: PlayerInfo.Distance);
             hasLogged500 = true;
        }
            if(PlayerInfo.Distance >= 750 && !hasLogged750)
         {
            FirebaseAnalytics.LogEvent(name:"player_distance750", parameterName:"travelled750", parameterValue: PlayerInfo.Distance);
             hasLogged750 = true;
        }
            if(PlayerInfo.Distance >= 1000 && !hasLogged1000)
         {
            FirebaseAnalytics.LogEvent(name:"player_distance1000", parameterName:"travelled1000", parameterValue: PlayerInfo.Distance);
             hasLogged1000 = true;
        }
    }
    
}
