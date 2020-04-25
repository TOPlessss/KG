using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Local : MonoBehaviour
{
    private Light LocalLight;
    // Start is called before the first frame update
    void Start()
    {
        {
            LocalLight = GetComponent<Light>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            LocalLight.enabled = !LocalLight.enabled;
        }
    }
}

