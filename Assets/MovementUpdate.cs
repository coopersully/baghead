using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementUpdate : MonoBehaviour
{
   public float speed = .1f;
  

   private void Update()
   {
      float xDirection = Input.GetAxis("Horizontal");
      float yDirection = Input.GetAxis("Vertical");
      Vector3 moveDirection = new Vector3(xDirection,yDirection, 0);
      transform.position += moveDirection * speed;
   }
}
