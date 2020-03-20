using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
    public GameObject SomeGameObject;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SomeGameObject.GetComponent<Rigidbody>().AddForce(0, 200,0);
        }
    }
}
