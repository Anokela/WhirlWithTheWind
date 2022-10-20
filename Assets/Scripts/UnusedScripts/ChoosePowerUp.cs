using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChoosePowerUp : MonoBehaviour
{
    public GameObject pc;
    private Vector3 spawnpoint;
    private GameObject menu;
    // private GameObject sprout;
    public GameObject ttp;
    public GameObject confirmMenu;
    public TextMeshProUGUI priceText;
    public int upDashPrice = 15;
    public Text blinking;
    public GameObject spawnManager;
    public int nextSpawnpointIndex;

    void Start()
    {
        priceText.text = upDashPrice.ToString();
        menu = GameObject.Find("SuccessMenu");
        // sprout = GameObject.Find("Sprout");
        // confirmMenu = GameObject.Find("PowerUpConfirmation");
    }

    public void OKPress()
    {
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);
        if (PlayerInfo.LightPoints >= upDashPrice)
        {
            PlayerInfo.LightPoints = PlayerInfo.LightPoints - upDashPrice;
            PlayerInfo.UpDashActive = 1;
            PlayerInfo.CurrentSpawnPoint = nextSpawnpointIndex;
            pc.SetActive(true);
            spawnManager.SendMessage("SpawnPlayer");
            // pc.transform.position = spawnpoint;
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
