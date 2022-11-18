using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingShiniesBg : MonoBehaviour
{
    private float backgroundSpeed;
    public Renderer backgroundRenderer;
    // Update is called once per frame
    void Update()
    {
        if(PlayerInfo.GameStarted)
        {
            backgroundSpeed = PlayerInfo.BoxSpeed / 12f;
            backgroundRenderer.material.mainTextureOffset += new Vector2(-PlayerInfo.BoxSpeed / 24f * Time.deltaTime, -backgroundSpeed * Time.deltaTime);
        }
    }
}
