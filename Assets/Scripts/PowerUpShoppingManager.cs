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
    public TextMeshProUGUI powerUpExpalanationText;
    public string sideDashExplanationText;
    public string upDashExplanationText;
    public string downDashExplanationText;
    public Button downDashButton;
    public Button upDashButton;
    public Button sideDashButton;
    private GameObject manager;
    public GameObject explanationPanel;
    public GameObject sideDashPriceContainer;
    public GameObject sideDashSoldImage;
    public GameObject upDashPriceContainer;
    public GameObject upDashSoldImage;
    public GameObject downDashPriceContainer;
    public GameObject downDashSoldImage;


    // Start is called before the first frame update
    void Start()
    {
        manager = this.gameObject;
        Invoke("AreButtonsInactive", 0);
        Invoke("SetPriceTexts", 0);
        Invoke("IsSideDashPurchased", 0);
        Invoke("IsUpDashPurchased", 0);
        Invoke("IsDownDashPurchased", 0);
    }

    public void BuyPowerUp()
    {
        if (PlayerInfo.LightPoints >= PowerUps.PowerUpsPrice)
        {
            if (EventSystem.current.currentSelectedGameObject.name == "UpDashPowerUp")
            {
                powerUpExpalanationText.text = upDashExplanationText;
                PlayerInfo.LightPoints = PlayerInfo.LightPoints - PowerUps.PowerUpsPrice;
                PlayerInfo.UpDashActive = 1;
                PlayerInfo.PowerUpsInUse++;
            }

            if (EventSystem.current.currentSelectedGameObject.name == "DownDashPowerUp")
            {
                powerUpExpalanationText.text = downDashExplanationText;
                PlayerInfo.LightPoints = PlayerInfo.LightPoints - PowerUps.PowerUpsPrice;
                PlayerInfo.DownDashActive = 1;
                PlayerInfo.PowerUpsInUse++;
            }

            if (EventSystem.current.currentSelectedGameObject.name == "SideDashPowerUp")
            {
                powerUpExpalanationText.text = sideDashExplanationText;
                PlayerInfo.LightPoints = PlayerInfo.LightPoints - PowerUps.PowerUpsPrice;
                PlayerInfo.SideDashActive = 1;
                PlayerInfo.PowerUpsInUse++;
            }
            Invoke("UpdatePowerUpPrices", 0);
            Invoke("SetPriceTexts", 0);
            Invoke("AreButtonsInactive", 0);
            Invoke("IsSideDashPurchased", 0);
            Invoke("IsUpDashPurchased", 0);
            Invoke("IsDownDashPurchased", 0);
            manager.SendMessage("SetShopButtonIcon");
            explanationPanel.SetActive(true);
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
        lightPointAmount.text = PlayerInfo.LightPoints.ToString();
    }

    public void UpdatePowerUpPrices()
    {
        if (PowerUps.PowerUpsPrice < (PlayerInfo.PowerUpsInShop * PlayerInfo.PowerUpsPrice))
        {
            PowerUps.PowerUpsPrice = (PlayerInfo.PowerUpsInUse + 1) * PlayerInfo.PowerUpsPrice;
        }
        else
        {
            PowerUps.PowerUpsPrice = PlayerInfo.PowerUpsInShop * PlayerInfo.PowerUpsPrice;
        }

    }

    public void IsSideDashPurchased()
    {
        if (PlayerInfo.SideDashActive == 1)
        {
            sideDashPriceContainer.SetActive(false);
            sideDashSoldImage.SetActive(true);
        } else
        {
            sideDashPriceContainer.SetActive(true);
            sideDashSoldImage.SetActive(false);
        }
    }

    public void IsUpDashPurchased()
    {
        if (PlayerInfo.UpDashActive == 1)
        {
            upDashPriceContainer.SetActive(false);
            upDashSoldImage.SetActive(true);
        }
        else
        {
            upDashPriceContainer.SetActive(true);
            upDashSoldImage.SetActive(false);
        }
    }
    public void IsDownDashPurchased()
    {
        if (PlayerInfo.DownDashActive == 1)
        {
            downDashPriceContainer.SetActive(false);
            downDashSoldImage.SetActive(true);
        }
        else
        {
            downDashPriceContainer.SetActive(true);
            downDashSoldImage.SetActive(false);
        }
    }
}
