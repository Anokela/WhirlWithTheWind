using UnityEngine;

public class SkyCanopy1Round : MonoBehaviour
{
    private float backgroundSpeed;
    public Renderer backgroundRenderer;

    // Update is called once per frame
    void Update()
    {
        if (PlayerInfo.GameStarted)
        {
            backgroundSpeed = PlayerInfo.BoxSpeed/24;
            backgroundRenderer.material.mainTextureOffset += new Vector2(0f, -backgroundSpeed * Time.deltaTime);
        }
    }
}
