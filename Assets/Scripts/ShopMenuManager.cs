using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenuManager : MonoBehaviour
{
    public GameObject shopMenu;

    public void OnshopButtonPress()
    {
        shopMenu.SetActive(true);
    }

    public void OnBackButtonPress()
    {
        shopMenu.SetActive(false);

    }
   
}
