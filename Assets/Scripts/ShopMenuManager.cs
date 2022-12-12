using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenuManager : MonoBehaviour
{
    public GameObject shopMenu;
    public GameObject explanationPanel;
    public GameObject buttonSoundManager;
    private AudioSource audioSrc;
    public AudioClip buttonClickSound;

    private void Start()
    {
        audioSrc = buttonSoundManager.GetComponent<AudioSource>();
    }
    public void OnshopButtonPress()
    {
        audioSrc.PlayOneShot(buttonClickSound);
        shopMenu.SetActive(true);
    }

    public void OnBackButtonPress()
    {
        audioSrc.PlayOneShot(buttonClickSound);
        shopMenu.SetActive(false);
        Invoke("ClosePowerUpExplanationPanel", 0);
    }

    public void ClosePowerUpExplanationPanel()
    {
        audioSrc.PlayOneShot(buttonClickSound);
        explanationPanel.SetActive(false);
    }
}
