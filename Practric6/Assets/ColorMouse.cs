using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMouse : MonoBehaviour
{
    private Renderer RenderProp;
    void Start()
    {
        RenderProp = GetComponent<Renderer>();
    }

    private void OnMouseEnter()
    {
        RenderProp.material.color = Color.blue;
    }
    
    private void OnMouseExit()
    {
        RenderProp.material.color = Color.green;
    }
}
