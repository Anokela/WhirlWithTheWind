using UnityEngine;
using UnityEngine.UI;

public class ShowSuccessMenu : MonoBehaviour
{
    public GameObject Panel;
    public GameObject pc;
    private Rigidbody2D rb;
    public Button downDashButton;
    public Button upDashButton;
    public Button sideDashButton;
    public Button antiBirdButton;
    public Button antiWebButton;
    // private GameObject sprout;

    void Start()
    {
        pc = GameObject.FindGameObjectWithTag("Player");
        rb = pc.GetComponent<Rigidbody2D>();
        // sprout = GameObject.Find("Sprout");
        // Panel = GameObject.Find("SuccessMenu");
        Panel.SetActive(false);
        // sprout.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.CompareTag("Player"))
        {
            Invoke("showPanel", 0);
            Invoke("AreButtonsInactive", 0);
        }
    }

    public void showPanel()
    {
        rb.velocity = Vector2.zero;
        rb.simulated = false;
        Panel.SetActive(true);
        // sprout.SetActive(true);
        pc.SetActive(false);
    }

    private void AreButtonsInactive()
    {
        if (upDashButton)
        {
            if (PlayerInfo.UpDashActive == 1 || PlayerInfo.LightPoints < PowerUps.UpDashPrice)
            {
                upDashButton.GetComponent<Button>().interactable = false;
            }
        }
        
        if(downDashButton)
        {
            if (PlayerInfo.DownDashActive == 1 || PlayerInfo.LightPoints < PowerUps.DownDashPrice)
            {
                downDashButton.GetComponent<Button>().interactable = false;
            }
        }
       
        if (sideDashButton)
        {
            if (PlayerInfo.SideDashActive == 1 || PlayerInfo.LightPoints < PowerUps.SideDashPrice)
            {
                sideDashButton.GetComponent<Button>().interactable = false;
            }
        }

        if (antiBirdButton)
        {
            if (PlayerInfo.AntiBirdActive == 1 || PlayerInfo.LightPoints < PowerUps.AntiBirdPrice)
            {
                antiBirdButton.GetComponent<Button>().interactable = false;
            }
        }

        if (antiWebButton)
        {
            if (PlayerInfo.AntiBirdActive == 1 || PlayerInfo.LightPoints < PowerUps.AntiBirdPrice)
            {
                antiWebButton.GetComponent<Button>().interactable = false;
            }
        }
    }
}