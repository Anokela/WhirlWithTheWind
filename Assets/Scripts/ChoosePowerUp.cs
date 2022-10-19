using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChoosePowerUp : MonoBehaviour
{
    public GameObject pc;
    private Vector3 spawnpoint;
    private GameObject menu;
    // private GameObject sprout;
    public GameObject ttp;
    public Text ttpText;
    public GameObject confirmMenu;
    public TextMeshProUGUI priceText;
    public int upDashPrice = 15;
    public Text blinking;

    // Start is called before the first frame update
    private void Awake()
    {
        spawnpoint = pc.transform.position;
    }

    void Start()
    {
        priceText.text = upDashPrice.ToString();
        menu = GameObject.Find("SuccessMenu");
        // sprout = GameObject.Find("Sprout");
        // confirmMenu = GameObject.Find("PowerUpConfirmation");
    }

    public void OKPress()
    { 
        if (PlayerInfo.LightPoints >= upDashPrice)
        {
            PlayerInfo.LightPoints = PlayerInfo.LightPoints - upDashPrice;
            PlayerInfo.UpDashActive = 1;
            pc.SetActive(true);
            pc.transform.position = spawnpoint;
            confirmMenu.SetActive(false);
            // sprout.SetActive(false);
            ttp.SetActive(true);
            blinking.SendMessage("StartBlinking");
            menu.SetActive(false);
        }
        else
        {
            Debug.Log("Not enough lightpoints");
            return;
        }
    }

    public void CancelPress()
    {
        confirmMenu.SetActive(false);
    }
}
