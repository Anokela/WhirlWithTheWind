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
    void Awake()
    {
        PlayerInfo.PowerUpsPrice = powerUpsPrice;
        PlayerInfo.PowerUpsInShop = numberOfPowerUpsInShop;
        UpdatePowerUpPrices();
        // PowerUps.AntiBirdPrice = antiBirdPrice;
        // PowerUps.AntiWebPrice = antiWebPrice;
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
