using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ColorChanger : MonoBehaviour
{
   public Material Material;
   private void OnMouseDown()
   {
      Material.color = new Color(Random.value, Random.value, Random.value, 1);
   }
}
