
public class PlayerInfo
{
    private static int lightPoints;
    private static int isUpDashActive;
    private static int currentSpawnPoint;


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
}
