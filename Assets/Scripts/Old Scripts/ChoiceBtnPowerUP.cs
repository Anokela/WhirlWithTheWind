using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceBtnPowerUP : MonoBehaviour
{
    private GameObject confirmMenu;
    // Start is called before the first frame update
    void Start()
    {
        confirmMenu = GameObject.Find("PowerUpConfirmation");
        confirmMenu.SetActive(false);
    }

    public void PowerUpChoice()
    {
        confirmMenu.SetActive(true);
    }

}
