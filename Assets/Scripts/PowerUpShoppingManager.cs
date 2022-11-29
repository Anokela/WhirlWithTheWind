using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Firebase.Analytics;

public class PowerUpShoppingManager : MonoBehaviour
{
    public TextMeshProUGUI sideDashPrice;
    public TextMeshProUGUI upDashPrice;
    public TextMeshProUGUI downDashPrice;
    public TextMeshProUGUI lightPointAmount;
    // public TextMeshProUGUI powerUpExpalanationText;
    public Sprite sideDashExplanationText;
    public Sprite upDashExplanationText;
    public Sprite downDashExplanationText;
    public Image powerUpExplanationText;
    public Sprite sideDashBoughtExplanationHeader;
    public Sprite upDashBoughtExplanationHeader;
    public Sprite downDashBoughtExplanationHeader;
    public Sprite sideDashExplanationHeader;
    public Sprite upDashExplanationHeader;
    public Sprite downDashExplanationHeader;
    public Image explanationHeader;
/*    public Button downDashButton;
    public Button upDashButton;
    public Button sideDashButton;*/
    private GameObject manager;
    public GameObject explanationPanel;
    public GameObject sideDashPriceContainer;
    public GameObject sideDashSoldImage;
    public GameObject upDashPriceContainer;
    public GameObject upDashSoldImage;
    public GameObject downDashPriceContainer;
    public GameObject downDashSoldImage;
    public Button confirmBuyButton;
    private bool isBuying;
    private string currentPowerUp;


    // Start is called before the first frame update
    void Start()
    {
        manager = this.gameObject;
        //AreButtonsInactive();
        SetPriceTexts();
        IsSideDashPurchased();
        IsUpDashPurchased();
        IsDownDashPurchased();
    }

    public void OpenExplanationPanel() 
    {
        if (EventSystem.current.currentSelectedGameObject.name == "UpDashPowerUp")
        {
            if(PlayerInfo.UpDashActive == 0) 
            {
                currentPowerUp = "UpDashPowerUp";
                powerUpExplanationText.sprite = upDashExplanationText;
                explanationHeader.sprite = upDashExplanationHeader;
                isBuying = true;
            } else
            {
                powerUpExplanationText.sprite = upDashExplanationText;
                explanationHeader.sprite = upDashBoughtExplanationHeader;
                isBuying = false;
            }
        }

        if (EventSystem.current.currentSelectedGameObject.name == "DownDashPowerUp")
        {
            if(PlayerInfo.DownDashActive == 0)
            {
                currentPowerUp = "DownDashPowerUp";
                powerUpExplanationText.sprite = downDashExplanationText;
                explanationHeader.sprite = downDashExplanationHeader;
                isBuying = true;
            } else
            {
                powerUpExplanationText.sprite = downDashExplanationText;
                explanationHeader.sprite = downDashBoughtExplanationHeader;
                isBuying = false;
            }
        }

        if (EventSystem.current.currentSelectedGameObject.name == "SideDashPowerUp")
        {
            if(PlayerInfo.SideDashActive == 0)
            {
                currentPowerUp = "SideDashPowerUp";
                powerUpExplanationText.sprite = sideDashExplanationText;
                explanationHeader.sprite = sideDashExplanationHeader;
                isBuying = true;
            } else
            {
                powerUpExplanationText.sprite = sideDashExplanationText;
                explanationHeader.sprite = sideDashBoughtExplanationHeader;
                isBuying = false;
            }
        }
        explanationPanel.SetActive(true);
        AreButtonsInactive();
    }

    public void BuyPowerUp()
    {
        if(isBuying)
        {
            if (PlayerInfo.LightPoints >= PowerUps.PowerUpsPrice)
            {
                if (currentPowerUp == "UpDashPowerUp")
                {
                    PlayerInfo.LightPoints = PlayerInfo.LightPoints - PowerUps.PowerUpsPrice;
                    PlayerInfo.UpDashActive = 1;
                    PlayerInfo.PowerUpsInUse++;
                    FirebaseAnalytics.LogEvent(name:"Power_up_management", parameterName:"Power_up_bought", parameterValue: "UpDashPowerUp");
                }

                if (currentPowerUp == "DownDashPowerUp")
                {
                    PlayerInfo.LightPoints = PlayerInfo.LightPoints - PowerUps.PowerUpsPrice;
                    PlayerInfo.DownDashActive = 1;
                    PlayerInfo.PowerUpsInUse++;
                    FirebaseAnalytics.LogEvent(name:"Power_up_management", parameterName:"Power_up_bought", parameterValue: "DownDashPowerUp");
                }

                if (currentPowerUp == "SideDashPowerUp")
                {
                    PlayerInfo.LightPoints = PlayerInfo.LightPoints - PowerUps.PowerUpsPrice;
                    PlayerInfo.SideDashActive = 1;
                    PlayerInfo.PowerUpsInUse++;
                    FirebaseAnalytics.LogEvent(name:"Power_up_management", parameterName:"Power_up_bought", parameterValue: "SideDashPowerUp");
                }
                FirebaseAnalytics.LogEvent(name:"Power_up_management", parameterName:"Power_ups_in_use", parameterValue: PlayerInfo.PowerUpsInUse);
                UpdatePowerUpPrices();
                SetPriceTexts();
                //AreButtonsInactive();
                IsSideDashPurchased();
                IsUpDashPurchased();
                IsDownDashPurchased();
                explanationPanel.SetActive(false);
                manager.SendMessage("SetShopButtonIcon");
                isBuying = false;
            }
        } else
        {
            explanationPanel.SetActive(false);
        }
    }

    public void AreButtonsInactive()
    {
        if(confirmBuyButton)
        {
            if (isBuying)
            {
                if (PlayerInfo.LightPoints < PowerUps.PowerUpsPrice)
                {
                    confirmBuyButton.GetComponent<Button>().interactable = false;
                }
                else
                {
                    confirmBuyButton.GetComponent<Button>().interactable = true;
                }

            }
            else
            {
                confirmBuyButton.GetComponent<Button>().interactable = true;
            }
        }
       
        /*
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
        }*/
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
