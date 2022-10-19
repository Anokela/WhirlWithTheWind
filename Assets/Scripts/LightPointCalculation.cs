using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LightPointCalculation : MonoBehaviour
{
	// Start is called before the first frame update
	public TextMeshProUGUI lightPointText;
	public static int lightPoints;

	// Use this for initialization
	void Update()
	{
		lightPointText.text = PlayerInfo.LightPoints.ToString();
    }

    void HandleCalculation()
	{
		Debug.Log("Calculation");
		lightPointText.text = PlayerInfo.LightPoints.ToString();
	}
}
