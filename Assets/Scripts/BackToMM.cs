using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMM : MonoBehaviour
{
    [SerializeField] private CanvasGroup myUIGroup;
    public GameObject endlessPrefsManager;

    private bool isFadingIn = false;
    public GameObject successMenu;
    private AudioSource audioSrc;
    public AudioClip buttonSound;
    public GameObject buttonSoundManager;


    private void Start()
    {
        audioSrc = buttonSoundManager.GetComponent<AudioSource>();
    }
    public void FadeIn()
    {
        isFadingIn = true;
        audioSrc.PlayOneShot(buttonSound);
        successMenu.SetActive(false);
    }
    private void Update()
    {
        if (isFadingIn)
        {
            if (myUIGroup.alpha < 1)
            {
                myUIGroup.alpha += 0.1f;
                if (myUIGroup.alpha >= 1)
                {
                    endlessPrefsManager.SendMessage("SavePrefs");
                    SceneManager.LoadScene("MainMenu");
                }
            }
        }
    }
}

