using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFollow : MonoBehaviour
{
    //Attach this script to your enemy; enemy will run at player
    public GameObject player;
    public int speed;
    void Update()
    {
        Transform transform1;
        (transform1 = transform).LookAt(player.transform);
        transform1.position+= transform1.forward * speed *Time.deltaTime;
    }
}//end class
