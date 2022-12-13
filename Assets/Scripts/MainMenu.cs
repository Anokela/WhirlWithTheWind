using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour   
{
    [SerializeField] private CanvasGroup myUIGroup;
    private AudioSource audioSrc;
    public AudioClip buttonSound;
    public GameObject buttonSoundManager;
    private bool isFadingIn = false;

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
            if (myUIGroup.alpha < 1)
            {
                myUIGroup.alpha += 0.1f;
                if (myUIGroup.alpha >= 1)
                {
                    SceneManager.LoadScene("Endless");                
                }
            }
        }
    }
}
