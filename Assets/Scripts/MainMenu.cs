using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour   
{
    [SerializeField] private CanvasGroup myUIGroup;
    private bool isFadingIn = false;
    public void FadeIn()
    {
        isFadingIn = true;
    }

    private void Update()
    {
        if (isFadingIn)
        {
            if (myUIGroup.alpha < 1)
            {
                myUIGroup.alpha += 0.025f;
                if (myUIGroup.alpha >= 1)
                {
                    SceneManager.LoadScene("Endless");                }
            }
        }
    }
}
