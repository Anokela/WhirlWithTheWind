using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PowerUpChoose : MonoBehaviour
{
    public GameObject pc;
    public GameObject menu;
    public TextMeshProUGUI priceText;
    [SerializeField] private Button thisButton;
    public string thisPowerUpName;
    public Text blinking;
    public GameObject spawnManager;
    public GameObject ttp;

    void Start()
    {
        if (thisPowerUpName == "upDash")
        {
            priceText.text = PowerUps.UpDashPrice.ToString();
        }

        if (thisPowerUpName == "downDash")
        {
            priceText.text = PowerUps.DownDashPrice.ToString();
        }

        if (thisPowerUpName == "sideDash")
        {
            priceText.text = PowerUps.SideDashPrice.ToString();
        }

        if (thisPowerUpName == "antiBird")
        {
            priceText.text = PowerUps.AntiBirdPrice.ToString();
        }

        if (thisPowerUpName == "antiWeb")
        {
            priceText.text = PowerUps.AntiWebPrice.ToString();
        }

        
    }
    public void BuyPowerUp () 
    {
        {
            if (EventSystem.current.currentSelectedGameObject.name == "DashUpPU")
            {
                PlayerInfo.LightPoints = PlayerInfo.LightPoints - PowerUps.UpDashPrice;
                PlayerInfo.UpDashActive = 1;
            }

            if (EventSystem.current.currentSelectedGameObject.name == "DashDownPU")
            {
                PlayerInfo.LightPoints = PlayerInfo.LightPoints - PowerUps.DownDashPrice;
                PlayerInfo.DownDashActive = 1;
            }

            if (EventSystem.current.currentSelectedGameObject.name == "DashSidePU")
            {
                PlayerInfo.LightPoints = PlayerInfo.LightPoints - PowerUps.SideDashPrice;
                PlayerInfo.SideDashActive = 1;
            }

            if (EventSystem.current.currentSelectedGameObject.name == "AntiBirdPU")
            {
                PlayerInfo.LightPoints = PlayerInfo.LightPoints - PowerUps.SideDashPrice;
                PlayerInfo.AntiBirdActive = 1;
            }

            if (EventSystem.current.currentSelectedGameObject.name == "AntiWebPU")
            {
                PlayerInfo.LightPoints = PlayerInfo.LightPoints - PowerUps.AntiWebPrice;
                PlayerInfo.AntiWebActive = 1;
            }
            // Invoke("AreButtonsInactive", 0);
            // Debug.Log("OSTO");
            PlayerInfo.CurrentSpawnPoint++;
            pc.SetActive(true);
            spawnManager.SendMessage("SpawnPlayer");
            ttp.SetActive(true);
            blinking.SendMessage("StartBlinking");
            menu.SetActive(false);
        }
    }
}
