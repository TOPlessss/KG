using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject door;

    private int flag = 0;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && flag == 0)
        {
            door.transform.Rotate(0f, 0f, 90f);
            flag = 1;
        }
        else if (Input.GetKeyDown(KeyCode.E) && flag == 1)
        {
            door.transform.Rotate(0f, 0f, -90f);
            flag = 0;
        }
    }
    
}
