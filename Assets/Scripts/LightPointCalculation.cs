using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LightPointCalculation : MonoBehaviour
{
	// Start is called before the first frame update
	public TextMeshProUGUI lightPointText;
	public int lightPoints = 0;

	// Use this for initialization
	void Start()
	{
		lightPointText.text = "0";
	}


	void HandleCalculation()
	{
		lightPoints += 1;
		lightPointText.text = lightPoints.ToString();
	}
}
