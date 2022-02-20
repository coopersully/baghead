using System;
using UnityEngine;

public class playerFall : MonoBehaviour
{
    
    private GameObject _respawnPoint;

    private void Start()
    {
        _respawnPoint = GameObject.FindGameObjectWithTag("Respawn");
    }

    private void Update()
    {
        // If the player crosses below -5 on the y-axis
        if (gameObject.transform.position.y < -5.0f)
        {
            gameObject.transform.SetPositionAndRotation(_respawnPoint.transform.position, Quaternion.identity);
        }
    }

}
