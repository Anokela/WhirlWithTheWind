using UnityEngine;
using UnityEngine.UI;

public class BlinkingText : MonoBehaviour
{
    // public Text flashingText;
    // string textToBlink;
    public float BlinkTime;
    public RawImage ttp;
    private Color tempColor;

    void Start()
    {
        /*flashingText = GetComponent<Text>();
        textToBlink = flashingText.text;*/
        tempColor = ttp.color;
        BlinkTime = 0.5f;
        Invoke("alphaZero", BlinkTime);
    }



    /*IEnumerator BlinkText()
    {
        while (true)
        {
            flashingText.text = textToBlink;
            yield return new WaitForSeconds(BlinkTime);
            flashingText.text = string.Empty;
            yield return new WaitForSeconds(BlinkTime);
        }
    }

    void StartBlinking()
    {
            StartCoroutine(BlinkText());
    }*/

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
