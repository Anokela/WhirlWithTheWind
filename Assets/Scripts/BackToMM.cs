using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMM : MonoBehaviour
{
    [SerializeField] private CanvasGroup myUIGroup;

    private bool isFadingIn = false;
    public GameObject successMenu;

    public void FadeIn()
    {
        isFadingIn = true;
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
                    SceneManager.LoadScene("MainMenu");
                }
            }
        }
    }
}

