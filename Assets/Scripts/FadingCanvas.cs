using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadingCanvas : MonoBehaviour
{
    [SerializeField] private CanvasGroup myUIGroup;
    public GameObject Panel;
    public GameObject pauseMenu;
    public GameObject prefManager;
    private bool isFadingIn = false;

    public void FadeIn()
    {
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
