using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class newMov : MonoBehaviour
{
     [SerializeField] private float moveSpeed = 10f;

     private CharacterController _characterController;
     public bool isGrounded;

     private void Awake() => _characterController = GetComponent<CharacterController>();

     private void FixedUpdate()
     {
          float horizontal = Input.GetAxis("Horizontal");
          float vertical = Input.GetAxis("Vertical");

          Vector3 direction = new Vector3(horizontal, 0, vertical);
          Vector3 movement = transform.TransformDirection(direction) * moveSpeed;

          isGrounded = _characterController.SimpleMove(movement);
     }
}
