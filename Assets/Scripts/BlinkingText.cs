using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkingText : MonoBehaviour
{
    public Text flashingText;
    string textToBlink;
    public float BlinkTime;

    void Start()
    {
        flashingText = GetComponent<Text>();
        textToBlink = flashingText.text;
        BlinkTime = 0.5f;
        StartBlinking();
    }




    IEnumerator BlinkText()
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
    }
}
