using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackgroundHorizontal : MonoBehaviour
{
    private float backgroundSpeed;
    public Renderer backgroundRenderer;
    // Update is called once per frame
    void Update()
    {
        if(PlayerInfo.GameStarted)
        {
            backgroundSpeed = PlayerInfo.BoxSpeed / 2f;
            backgroundRenderer.material.mainTextureOffset += new Vector2(-PlayerInfo.BoxSpeed / 24f * Time.deltaTime, -backgroundSpeed * Time.deltaTime);
        }
    }
}