using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackGroundLeft : MonoBehaviour
{
    // Start is called before the first frame update
    private float backgroundSpeed;
    public Renderer backgroundRenderer;
    // Update is called once per frame
    void Update()
    {
        if (PlayerInfo.GameStarted)
        {
            backgroundSpeed = PlayerInfo.BoxSpeed / 1.35f;
            backgroundRenderer.material.mainTextureOffset += new Vector2(0f, backgroundSpeed * Time.deltaTime);
        }
    }
}
