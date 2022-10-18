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
		lightPointText.text = PlayerInfo.LightPoints.ToString();
		if (resetPrefs)
        {
			PlayerPrefs.SetInt("LightPoints", 0);
			PlayerPrefs.SetInt("UpDashActive", 0);
			PlayerPrefs.Save();
		}
    }

    void HandleCalculation()
	{
		Debug.Log("Calculation");
		// lightPoints += 1;
		lightPointText.text = PlayerInfo.LightPoints.ToString();
		PlayerPrefs.SetInt("LightPoints", lightPoints);
		PlayerPrefs.Save();
	}
}
