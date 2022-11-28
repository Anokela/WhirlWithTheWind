using UnityEngine;

public class PowerUpManagement : MonoBehaviour
{
    // Start is called before the first frame update
    public int downDashPrice;
    public int upDashPrice;
    public int sideDashPrice;
    public int powerUpsPrice;
    public int numberOfPowerUpsInShop;
    // public int antiBirdPrice;
    // public int antiWebPrice;

    void Start()
    {
        PlayerInfo.PowerUpsInUse = 0;
        if (PlayerInfo.SideDashActive == 1)
        {
            PlayerInfo.PowerUpsInUse = PlayerInfo.PowerUpsInUse + 1;
        }
        if (PlayerInfo.UpDashActive == 1)
        {
            PlayerInfo.PowerUpsInUse = PlayerInfo.PowerUpsInUse + 1;
        }
        if (PlayerInfo.DownDashActive == 1)
        {
            PlayerInfo.PowerUpsInUse = PlayerInfo.PowerUpsInUse + 1;
        }
        PlayerInfo.PowerUpsPrice = powerUpsPrice;
        PlayerInfo.PowerUpsInShop = numberOfPowerUpsInShop;
        UpdatePowerUpPrices();
    }

    public void UpdatePowerUpPrices()
    {
        /*PowerUps.DownDashPrice = (PlayerInfo.PowerUpsInUse + 1) * downDashPrice;
        PowerUps.UpDashPrice = (PlayerInfo.PowerUpsInUse + 1) * upDashPrice;
        PowerUps.SideDashPrice = (PlayerInfo.PowerUpsInUse + 1) * sideDashPrice;*/
        if (PowerUps.PowerUpsPrice < (PlayerInfo.PowerUpsInShop * PlayerInfo.PowerUpsPrice)) {
            PowerUps.PowerUpsPrice = (PlayerInfo.PowerUpsInUse + 1) * PlayerInfo.PowerUpsPrice;
        } else
        {
            PowerUps.PowerUpsPrice = PlayerInfo.PowerUpsInShop * PlayerInfo.PowerUpsPrice;
        }
        
    }
}
