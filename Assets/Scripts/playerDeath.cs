using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDeath : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private Transform respawnPoint;

    private GameObject myGameObject;
    private int playerHealth;


    private void Start()
    {
        playerHealth = 1;
    }


    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = respawnPoint.transform.position;

        //Ray myRay = new Ray(transform.position, new Vector3 (100f, 0f, 0f));
        RaycastHit hit;
        //Physics.Raycast(myRay, out hit);

        //Debug.DrawLine(transform.position, new Vector3(100f, 0f, 0f), Color.black);

        if (Physics.Raycast(transform.position, new Vector3(100f, 0f, 0f), out hit))
        {
            Debug.DrawRay(transform.position, transform.forward);
            if (Input.GetKey(KeyCode.Space))
            {
                Destroy(myGameObject);
            }
        }

    }
}

