using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    public Vector3 Speed;
    void Update()
    {
        GetComponent<Rigidbody>().velocity = Speed * Time.deltaTime;
    }
}
