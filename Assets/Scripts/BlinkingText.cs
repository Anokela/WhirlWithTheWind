using UnityEngine;
using UnityEngine.UI;

public class BlinkingText : MonoBehaviour
{
    public float BlinkTime;
    public RawImage ttp;
    private Color tempColor;

    void Start()
    {
        tempColor = ttp.color;
        BlinkTime = 0.5f;
        Invoke("alphaZero", BlinkTime);
    }

    void alphaZero()
    {
        tempColor = ttp.color;
        tempColor.a = 0f;
        ttp.color = tempColor;
        Invoke("alphaOne", BlinkTime);
    }

    void alphaOne()
    {
        tempColor = ttp.color;
        tempColor.a = 1f;
        ttp.color = tempColor;
        Invoke("alphaZero", BlinkTime);
    }
}
