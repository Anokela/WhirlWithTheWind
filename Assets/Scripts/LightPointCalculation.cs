using UnityEngine;
using TMPro;

public class LightPointCalculation : MonoBehaviour
{
	public TextMeshProUGUI lightPointText;
	public TextMeshProUGUI runLightPointText; 
	public TextMeshProUGUI distanceText;
	public TextMeshProUGUI highScoreText;
	public static int lightPoints;

	void Update()
	{
		lightPointText.text = PlayerInfo.LightPoints.ToString();
		runLightPointText.text = PlayerInfo.RunLightPoints.ToString();
		distanceText.text = PlayerInfo.Distance.ToString("0");
		highScoreText.text = PlayerInfo.HighScore.ToString("0");
	}
}
