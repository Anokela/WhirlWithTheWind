
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
}
