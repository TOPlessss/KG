using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Specifications : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log(name);
        Debug.Log(transform.position);
        Debug.Log(GetComponent<Renderer>().material.color);
        Debug.Log(GetComponent<Rigidbody>().mass);
    }
}
