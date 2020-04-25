using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnScreen : MonoBehaviour
{
    private int flag = 0;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F) && flag == 0)
        {
            GetComponent<Renderer>().material.color = Color.white;
            flag = 1;
        }
        else if (Input.GetKeyDown(KeyCode.F) && flag == 1)
        {
            GetComponent<Renderer>().material.color = Color.black;
            flag = 0;
        }
    }
}
