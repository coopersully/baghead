using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{
    public GameObject Player;
    public void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("Player"))
        {
            Player.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
