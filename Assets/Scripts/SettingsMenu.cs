using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject settingsMenu;
    public GameObject buttonSoundManager;
    private AudioSource audioSrc;
    public AudioClip buttonClickSound;

    private void Start()
    {
        audioSrc = buttonSoundManager.GetComponent<AudioSource>();
    }

    public void CloseMenu()
    {
        settingsMenu.SetActive(false);
        audioSrc.PlayOneShot(buttonClickSound);
    }

    public void OpenMenu()
    {
        settingsMenu.SetActive(true);
        audioSrc.PlayOneShot(buttonClickSound);
    }
}
