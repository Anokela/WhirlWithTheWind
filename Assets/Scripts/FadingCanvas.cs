using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadingCanvas : MonoBehaviour
{
    [SerializeField] private CanvasGroup myUIGroup;
    public GameObject Panel;
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
            if (myUIGroup.alpha < 1)
            {
                myUIGroup.alpha += 0.025f;
                if (myUIGroup.alpha >= 1)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
            }
        }
    }
}
