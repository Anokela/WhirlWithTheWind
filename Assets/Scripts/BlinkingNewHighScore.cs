
using UnityEngine;
using UnityEngine.UI;

public class BlinkingNewHighScore : MonoBehaviour
{
    public Image distanceBg;
    //private Color tempBgAlpha;
    private bool isAlphaZero;
    private Vector2 bgScale;
    // Start is called before the first frame update
    void Start()
    {
        //tempBgAlpha = distanceBg.color;
        bgScale = distanceBg.transform.localScale;
        isAlphaZero = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        BgSizeController();
    }

    //control images alpha value
    /*    void BgAlphaControl()
        {
            if (!isAlphaZero)
            {
                tempBgAlpha = distanceBg.color;
                tempBgAlpha.a -= 0.05f;
                distanceBg.color = tempBgAlpha;
                if(tempBgAlpha.a <= 0f)
                {
                    isAlphaZero = true;
                }
            }
            if (isAlphaZero)
            {
                tempBgAlpha = distanceBg.color;
                tempBgAlpha.a += 0.05f;
                distanceBg.color = tempBgAlpha;
                if (tempBgAlpha.a >= 1f)
                {
                    isAlphaZero = false;
                }
            }
        }*/

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
