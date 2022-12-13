using UnityEngine;

public class LoopingBackGroundLeft : MonoBehaviour
{
    private float backgroundSpeed;
    public Renderer backgroundRenderer;

    void Update()
    {
        if (PlayerInfo.GameStarted)
        {
            backgroundSpeed = PlayerInfo.BoxSpeed / 1f;
            backgroundRenderer.material.mainTextureOffset += new Vector2(0f, backgroundSpeed * Time.deltaTime);
        }
    }
}
