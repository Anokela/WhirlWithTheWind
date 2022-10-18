using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChoosePowerUp : MonoBehaviour
{
    public GameObject pc;
    private Vector3 spawnpoint;
    private GameObject menu;
    // private GameObject sprout;
    public GameObject ttp;
    private GameObject confirmMenu;
    public TextMeshProUGUI priceText;
    private int totalLightPoints;
    public int upDashPrice = 15;

    // Start is called before the first frame update
    private void Awake()
    {
        spawnpoint = pc.transform.position;
    }

    void Start()
    {
        /*if (PlayerPrefs.HasKey("LightPoints"))
        {
            totalLightPoints = PlayerPrefs.GetInt("LightPoints");
        }*/
        priceText.text = upDashPrice.ToString();
        // pc = GameObject.FindGameObjectWithTag("Player");
        // spawnpoint = pc.transform.position;
        menu = GameObject.Find("SuccessMenu");
        // sprout = GameObject.Find("Sprout");
        // ttp = GameObject.Find("TapToPlay");
        confirmMenu = GameObject.Find("PowerUpConfirmation");
    }

    private void Update()
    {
        if (PlayerPrefs.HasKey("LightPoints"))
        {
            totalLightPoints = PlayerPrefs.GetInt("LightPoints");
        }
    }
    // Update is called once per frame
    public void OKPress()
    { 
        if (totalLightPoints >= upDashPrice)
        {

            PlayerPrefs.SetInt("LightPoints", totalLightPoints - upDashPrice);
            PlayerPrefs.SetInt("UpDashActive", 1);
            PlayerPrefs.Save();
            pc.SetActive(true);
            pc.transform.position = spawnpoint;
            confirmMenu.SetActive(false);
            // sprout.SetActive(false);
            ttp.SetActive(true);
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
