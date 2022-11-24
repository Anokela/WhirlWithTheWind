
public class PlayerInfo
{
    private static int lightPoints;
    private static int isUpDashActive;
    private static int isDownDashActive;
    private static int isSideDashActive;
    private static int currentSpawnPoint;
    private static int isAntiBirdActive;
    private static int isAntiWebActive;
    private static float boxSpeed;
    private static float distance;
    private static float highScore;
    private static int runLightPoints;
    private static bool gameStarted;
    private static int powerUpsInUse;
    private static bool stopLoopingAudio;
    private static int powerUpsPrice;
    private static int powerUpsInShop;
    private static float masterVolume;
    private static float musicVolume;
    private static float sFXVolume;
    private static int isMasterMuted;
    private static int isMusicMuted;
    private static int isSFXMuted;

    public static int LightPoints
    {
        get
        {
            return lightPoints;
        }
        set
        {
            lightPoints = value;
        }
    }

    public static int UpDashActive
    {
        get
        {
            return isUpDashActive;
        }
        set
        {
            isUpDashActive = value;
        }
    }

    public static int DownDashActive
    {
        get
        {
            return isDownDashActive;
        }
        set
        {
            isDownDashActive = value;
        }
    }
    public static int SideDashActive

    {
        get
        {
            return isSideDashActive;
        }
        set
        {
            isSideDashActive = value;
        }
    }

    public static int AntiBirdActive

    {
        get
        {
            return isAntiBirdActive;
        }
        set
        {
            isAntiBirdActive = value;
        }
    }

    public static int AntiWebActive

    {
        get
        {
            return isAntiWebActive;
        }
        set
        {
            isAntiWebActive = value;
        }
    }

    public static int CurrentSpawnPoint
    {
        get
        {
            return currentSpawnPoint;
        }
        set
        {
            currentSpawnPoint = value;
        }
    }

    public static float BoxSpeed
    {
        get
        {
            return boxSpeed;
        }
        set
        {
            boxSpeed = value;
        }
    }

    public static float Distance
    {
        get
        {
            return distance;
        }
        set
        {
            distance = value;
        }
    }

    public static float HighScore
    {
        get
        {
            return highScore;
        }
        set
        {
            highScore = value;
        }
    }
    public static int RunLightPoints
    {
        get
        {
            return runLightPoints;
        }
        set
        {
            runLightPoints = value;
        }
    }

    public static bool GameStarted
    {
        get
        {
            return gameStarted;
        }
        set
        {
            gameStarted = value;
        }
    }

    public static int PowerUpsInUse
    {
        get
        {
            return powerUpsInUse;
        }
        set
        {
            powerUpsInUse = value;
        }
    }

    public static bool StopLoopingAudio
    {
        get
        {
            return stopLoopingAudio;
        }
        set
        {
        stopLoopingAudio = value;
        }
    }

    public static int PowerUpsPrice
    {
        get
        {
            return powerUpsPrice;
        }
        set
        {
            powerUpsPrice = value;
        }
    }

    public static int PowerUpsInShop
    {
        get
        {
            return powerUpsInShop;
        }
        set
        {
            powerUpsInShop = value;
        }
    }

    public static float MasterVolume
    {
        get
        {
            return masterVolume;
        }
        set
        {
            masterVolume = value;
        }
    }
    public static float MusicVolume
    {
        get
        {
            return musicVolume;
        }
        set
        {
            musicVolume = value;
        }
    }
    public static float SFXVolume
    {
        get
        {
            return sFXVolume;
        }
        set
        {
            sFXVolume = value;
        }
    }

    public static int IsMasterMuted
    {
        get
        {
            return isMasterMuted;
        }
        set
        {
            isMasterMuted = value;
        }
    }

    public static int IsMusicMuted
    {
        get
        {
            return isMusicMuted;
        }
        set
        {
            isMusicMuted = value;
        }
    }

    public static int IsSFXMuted
    {
        get
        {
            return isSFXMuted;
        }
        set
        {
            isSFXMuted = value;
        }
    }

}
