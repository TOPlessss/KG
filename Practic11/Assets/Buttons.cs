﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
   public GameObject gameObjectPanel;
   public GameObject gameObjectImage;
   public Sprite NewSprite;

   public void ChangeImage()
   {
      gameObjectImage.GetComponent<Image>().sprite = NewSprite;
   }
   
   public void Close()
   {
      gameObjectPanel.SetActive(false);
   }
}
