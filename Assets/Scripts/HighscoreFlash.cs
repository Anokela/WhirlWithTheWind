using UnityEngine;
using UnityEngine.UI;

public class HighscoreFlash : MonoBehaviour
{
    public Image distanceBg;
    private bool isAlphaZero;
    private Vector2 bgScale;
    void Start()
    {
        bgScale = distanceBg.transform.localScale;
        isAlphaZero = false;
    }

    void FixedUpdate()
    {
        if (PlayerInfo.GameStarted)
        {
            if (PlayerInfo.Distance >= PlayerInfo.HighScore && PlayerInfo.HasPlayedSeedFall == 1)
            {
                BgSizeController();
            }
        }
    }

    void BgSizeController()
    {
        if (!isAlphaZero)
        {
            bgScale = distanceBg.transform.localScale;
            bgScale.x -= 0.025f;
            bgScale.y -= 0.025f;
            distanceBg.transform.localScale = bgScale;
            if (bgScale.x <= 1f)
            {
                isAlphaZero = true;
            }
        }
        if (isAlphaZero)
        {
            bgScale = distanceBg.transform.localScale;
            bgScale.x += 0.025f;
            bgScale.y += 0.025f;
            distanceBg.transform.localScale = bgScale;
            if (bgScale.x >= 1.2f)
            {
                isAlphaZero = false;
            }
        }
    }
}
