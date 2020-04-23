using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Application.LoadLevel("Scene1");
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel("Scene2");
        }
    }
}
