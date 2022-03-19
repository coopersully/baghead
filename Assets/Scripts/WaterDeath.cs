using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterDeath : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }//end trigger
    //[SerializeField] private Transform Player;
    //[SerializeField] private Transform respawnPoint;

    //private void OnTriggerEnter(Collider other)
    //{
      //  Player.transform.position = respawnPoint.transform.position;
    //}
}//end class
