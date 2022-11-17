using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public GameObject manager;
    public void Restart ()
    {
        SceneManager.LoadScene("Endless");
    }
}
