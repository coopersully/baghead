using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPatrol : MonoBehaviour
{
    //this script creates an array of points for the enemy to patrol between. Simply attach script to enemy
    public Transform[] wayPoints; 
    public int speed;// choose enemy patrol speed

    private int _waypointIndex;
    private float _distance;
    
    void Start()
    {
        _waypointIndex = 0;
        transform.LookAt(wayPoints[_waypointIndex].position);
    }

    // Update is called once per frame
    void Update()
    {
        _distance = Vector3.Distance(transform.position, wayPoints[_waypointIndex].position);
        if (_distance < 1f)
        {
            IncreaseIndex();
        }
        Patrol();
    }//update over

    void Patrol()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void IncreaseIndex()
    {
        _waypointIndex++;
        if (_waypointIndex >= wayPoints.Length)
        {
            _waypointIndex = 0;
        }
        transform.LookAt(wayPoints[_waypointIndex].position);
    }
}
