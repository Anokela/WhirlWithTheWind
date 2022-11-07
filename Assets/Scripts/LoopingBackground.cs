using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    private float backgroundSpeed;
    public Renderer backgroundRenderer;
    // Update is called once per frame
    void Update()
    {
        if(PlayerInfo.GameStarted)
        {
            backgroundSpeed = PlayerInfo.BoxSpeed / 4f;
            backgroundRenderer.material.mainTextureOffset += new Vector2(0f, -backgroundSpeed * 0.004f);
        }
    }
}
