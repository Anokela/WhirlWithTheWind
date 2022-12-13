using UnityEngine;
using UnityEngine.SceneManagement;

public class FadingCanvas : MonoBehaviour
{
    [SerializeField] private CanvasGroup myUIGroup;
    public GameObject Panel;
    public GameObject pauseMenu;
    public GameObject prefManager;
    private bool isFadingIn = false;
    private AudioSource audioSrc;
    public AudioClip buttonSound;
    public GameObject buttonSoundManager;

    private void Start()
    {
        audioSrc = buttonSoundManager.GetComponent<AudioSource>();
    }
    public void FadeIn()
    {
        audioSrc.PlayOneShot(buttonSound);
        isFadingIn = true;
    }

    private void Update()
    {
        if (isFadingIn)
        {
            Panel.SetActive(false);
            pauseMenu.SetActive(false);
            if (myUIGroup.alpha < 1)
            {
                myUIGroup.alpha += 0.1f;
                if (myUIGroup.alpha >= 1)
                {
                    prefManager.SendMessage("SavePrefs");
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
            }
        }
    }
}
