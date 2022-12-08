using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject settingsMenu;

    public void CloseMenu()
    {
        settingsMenu.SetActive(false);
    }
    public void OpenMenu()
    {
        settingsMenu.SetActive(true);
    }

    public void StartTutorial()
    {

    }
}
