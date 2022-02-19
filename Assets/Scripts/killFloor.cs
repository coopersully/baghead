using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killFloor : MonoBehaviour
{
    [SerializeField] 
    private Transform player;
    [SerializeField] 
    private Transform respawnPoint;

    private bool alive = true;

    private void OnTriggerEnter(Collider other) 
    {
        player.transform.position = respawnPoint.transform.position;
        if (other.gameObject.tag == "Enemy")
        {
            player.transform.position = respawnPoint.transform.position;
        }
    }
}
