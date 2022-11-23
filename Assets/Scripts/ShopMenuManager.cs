using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenuManager : MonoBehaviour
{
    public GameObject shopMenu;
    public GameObject explanationPanel;

    public void OnshopButtonPress()
    {
        shopMenu.SetActive(true);
    }

    public void OnBackButtonPress()
    {
        shopMenu.SetActive(false);
        Invoke("ClosePowerUpExplanationPanel", 0);

    }

    public void ClosePowerUpExplanationPanel()
    {
        explanationPanel.SetActive(false);
    }
   
}
