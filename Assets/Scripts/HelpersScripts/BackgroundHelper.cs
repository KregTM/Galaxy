using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundHelper : MonoBehaviour
{
    public Renderer backgroundRenderer;

    void Update()
    {
        if (backgroundRenderer != null)
        {
            backgroundRenderer.material.mainTextureOffset = new Vector2(0.0f, 0.1f * Time.time);
        }
    }
}
