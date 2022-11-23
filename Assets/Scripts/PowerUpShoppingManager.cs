using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class PowerUpShoppingManager : MonoBehaviour
{
    public TextMeshProUGUI sideDashPrice;
    public TextMeshProUGUI upDashPrice;
    public TextMeshProUGUI downDashPrice;
    public TextMeshProUGUI lightPointAmount;
    public Button downDashButton;
    public Button upDashButton;
    public Button sideDashButton;
    private GameObject manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = this.gameObject;
        Invoke("AreButtonsInactive", 0);
        Invoke("SetPriceTexts", 0);
        lightPointAmount.text = PlayerInfo.LightPoints.ToString();
    }

    public void BuyPowerUp()
    {
        if (PlayerInfo.LightPoints >= PowerUps.PowerUpsPrice)
        {
            if (EventSystem.current.currentSelectedGameObject.name == "UpDashPowerUp")
            {
                PlayerInfo.LightPoints = PlayerInfo.LightPoints - PowerUps.PowerUpsPrice;
                PlayerInfo.UpDashActive = 1;
                PlayerInfo.PowerUpsInUse++;
            }

            if (EventSystem.current.currentSelectedGameObject.name == "DownDashPowerUp")
            {
                PlayerInfo.LightPoints = PlayerInfo.LightPoints - PowerUps.PowerUpsPrice;
                PlayerInfo.DownDashActive = 1;
                PlayerInfo.PowerUpsInUse++;
            }

            if (EventSystem.current.currentSelectedGameObject.name == "SideDashPowerUp")
            {
                PlayerInfo.LightPoints = PlayerInfo.LightPoints - PowerUps.PowerUpsPrice;
                PlayerInfo.SideDashActive = 1;
                PlayerInfo.PowerUpsInUse++;
            }
            Invoke("UpdatePowerUpPrices", 0);
            Invoke("SetPriceTexts", 0);
            Invoke("AreButtonsInactive", 0);
            manager.SendMessage("SetShopButtonIcon");
            lightPointAmount.text = PlayerInfo.LightPoints.ToString();
        }
    }

    public void AreButtonsInactive()
    {
        if (upDashButton)
        {
            if (PlayerInfo.UpDashActive == 1 || PlayerInfo.LightPoints < PowerUps.PowerUpsPrice)
            {
                upDashButton.GetComponent<Button>().interactable = false;
            } else
            {
                upDashButton.GetComponent<Button>().interactable = true;
            }
        }

        if (downDashButton)
        {
            if (PlayerInfo.DownDashActive == 1 || PlayerInfo.LightPoints < PowerUps.PowerUpsPrice)
            {
                downDashButton.GetComponent<Button>().interactable = false;
            } else
            {
                downDashButton.GetComponent<Button>().interactable = true;
            }
        }

        if (sideDashButton)
        {
            if (PlayerInfo.SideDashActive == 1 || PlayerInfo.LightPoints < PowerUps.PowerUpsPrice)
            {
                sideDashButton.GetComponent<Button>().interactable = false;
            } else
            {
                sideDashButton.GetComponent<Button>().interactable = true;
            }
        }
    }

    public void SetPriceTexts()
    {
        sideDashPrice.text = PowerUps.PowerUpsPrice.ToString();
        upDashPrice.text = PowerUps.PowerUpsPrice.ToString();
        downDashPrice.text = PowerUps.PowerUpsPrice.ToString();
    }

    public void UpdatePowerUpPrices()
    {
        PowerUps.PowerUpsPrice = (PlayerInfo.PowerUpsInUse + 1) * PlayerInfo.PowerUpsPrice;
    }
}
