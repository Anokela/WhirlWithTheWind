using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeTrunksLoop : MonoBehaviour
{
    private float backgroundSpeed;
    public Renderer backgroundRenderer;
    // Update is called once per frame
    void Update()
    {
        if (PlayerInfo.GameStarted)
        {
            backgroundSpeed = PlayerInfo.BoxSpeed;
            backgroundRenderer.material.mainTextureOffset += new Vector2(0f, -backgroundSpeed * Time.deltaTime);
        }
    }
}
