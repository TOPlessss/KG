using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowOpen : MonoBehaviour
{
    public GameObject window;

    private int flag = 0;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && flag == 0)
        {
            window.transform.Translate(0f, 0f, 30f);
            flag = 1;
        }
        else if (Input.GetKeyDown(KeyCode.E) && flag == 1)
        {
            window.transform.Translate(0f, 0f, -30f);
            flag = 0;
        }
    }

}
