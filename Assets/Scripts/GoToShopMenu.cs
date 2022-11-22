using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToShopMenu : MonoBehaviour
{
    [SerializeField] GameObject shopMenu;

    public void OnshopButtonPress()
    {
        shopMenu.SetActive(true);
    }
   
}
