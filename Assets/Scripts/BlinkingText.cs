using System.Collections;
using System.Collections.Generic;
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
        BlinkTime = 0.5f;
        StartBlinking();
    }

    IEnumerator BlinkText()
    {
        while (true)
        {
            tempColor = ttp.color;
            tempColor.a = 0f;
            ttp.color = tempColor;
            // flashingText.text = textToBlink;
            yield return new WaitForSeconds(BlinkTime);
            // flashingText.text = string.Empty;
            tempColor = ttp.color;
            tempColor.a = 1f;
            ttp.color = tempColor;
            yield return new WaitForSeconds(BlinkTime);
        }
    }

    void StartBlinking()
    {
            StartCoroutine(BlinkText());
    }
}
