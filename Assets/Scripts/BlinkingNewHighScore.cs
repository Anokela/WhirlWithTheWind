
using UnityEngine;
using UnityEngine.UI;

public class BlinkingNewHighScore : MonoBehaviour
{
    public Image distanceBg;
    private bool isAlphaZero;
    private Vector2 bgScale;

    // Start is called before the first frame update
    void Start()
    {
        bgScale = distanceBg.transform.localScale;
        isAlphaZero = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        BgSizeController();
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
