using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
   public float Speed;

   void Update()
   {
      transform.Translate(transform.forward * Time.deltaTime * Speed);
   }
}
