using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalLight : MonoBehaviour
{
    private Light MyLight;
    // Start is called before the first frame update
    void Start()
    {
        {
            MyLight = GetComponent<Light>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            MyLight.enabled = !MyLight.enabled;
        }
    }
}
