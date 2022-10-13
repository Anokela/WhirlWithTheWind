using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LightPointCalculation : MonoBehaviour
{
	// Start is called before the first frame update
	public TextMeshProUGUI lightPointText;
	public static int lightPoints;
	public bool resetPrefs = false;

	// Use this for initialization
	void Start()
	{
		if (resetPrefs)
        {
			PlayerPrefs.SetInt("LightPoints", 0);
			PlayerPrefs.Save();
		}
		if(PlayerPrefs.HasKey("LightPoints"))
        {
			lightPoints = PlayerPrefs.GetInt("LightPoints");
			Debug.Log("HEI!!!");
			Debug.Log(lightPoints);
			lightPointText.text = lightPoints.ToString();
		}
	}


	void HandleCalculation()
	{
		Debug.Log("Calculation");
		lightPoints += 1;
		lightPointText.text = lightPoints.ToString();
		PlayerPrefs.SetInt("LightPoints", lightPoints);
		PlayerPrefs.Save();
	}
}
