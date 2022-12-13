using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseMenu;
    private AudioSource audioSrc;
    public AudioClip buttonSound;
    public GameObject buttonSoundManager;


    private void Start()
    {
        audioSrc = buttonSoundManager.GetComponent<AudioSource>();
    }

    public void Pause()
    {
        if (PlayerInfo.GameStarted)
        {
            audioSrc.PlayOneShot(buttonSound);
            pauseMenu.SetActive(true);
            PlayerInfo.GameStarted = false;
        } 
    }

    public void UnPause()
    {
        audioSrc.PlayOneShot(buttonSound);
        pauseMenu.SetActive(false);
        PlayerInfo.GameStarted = true;
    }



    private void Update()
    {
        // Check if Back was pressed this frame
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }
}
