using UnityEngine;

public class LoopingBackgroundHorizontal : MonoBehaviour
{
    private float backgroundSpeed;
    public Renderer backgroundRenderer;
    private Color tempColor;
    private void Start()
    {
        tempColor = backgroundRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerInfo.GameStarted)
        {
            backgroundSpeed = PlayerInfo.BoxSpeed / 2f;
            backgroundRenderer.material.mainTextureOffset += new Vector2(-PlayerInfo.BoxSpeed / 24f * Time.deltaTime, -backgroundSpeed * Time.deltaTime);
        }
        if (PlayerInfo.Distance > 300)
        {
            if(tempColor.a > 0)
            {
                tempColor.a = tempColor.a - 0.001f;
                backgroundRenderer.material.color = tempColor;
            }   
        }
    }
}
