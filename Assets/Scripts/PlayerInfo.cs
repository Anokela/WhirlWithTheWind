
public class PlayerInfo
{
    private static int lightPoints;
    private static int isUpDashActive;


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
}
