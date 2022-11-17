using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LightPointCalculation : MonoBehaviour
{
	// Start is called before the first frame update
	public TextMeshProUGUI lightPointText;
	public TextMeshProUGUI runLightPointText; 
	public TextMeshProUGUI distanceText;
	public TextMeshProUGUI highScoreText;
	public static int lightPoints;

	// Use this for initialization
	void Update()
	{
		lightPointText.text = PlayerInfo.LightPoints.ToString();
		runLightPointText.text = PlayerInfo.RunLightPoints.ToString();
		distanceText.text = PlayerInfo.Distance.ToString("0");
		highScoreText.text = PlayerInfo.HighScore.ToString("0");
	}
}
