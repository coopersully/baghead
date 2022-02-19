using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killFloor : MonoBehaviour
{
    [SerializeField] 
    private Transform player;
    [SerializeField] 
    private Transform respawnPoint;

    private void OnTriggerEnter(Collider other) {
        player.transform.position = respawnPoint.transform.position;
    }

}
