﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class BuoyancyObj : MonoBehaviour
{
    public float underWaterDrag = 3;

    public float underWaterAngularDrag = 1;

    public float airDrag = 0f;

    public float airAngularDrag = 0.05f;

    public float floatingPower = 15f;

    public float waterHeight = 0f;

    Rigidbody _Rigidbody;

    bool underwater;

    private void Start()
    {
        _Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float difference = transform.position.y - waterHeight;

        if (difference < 0)
        {
            _Rigidbody.AddForceAtPosition(Vector3.up * floatingPower * Mathf.Abs(difference), transform.position,
                ForceMode.Force);
            if (!underwater)
            {
                underwater = true;
                SwitchState(true); //calls switch to manipulate physics on box; passes in true to return underwater physics
            } //end nested if
        } //end if
        else if (underwater)
        {
            underwater = false;
            SwitchState(false);// calls switch passing in false, which will trigger above water physics
        }

    } //end fixed update

    void SwitchState(bool isUnderWater)
    {
        if (isUnderWater)
        {
            _Rigidbody.drag = underWaterDrag;
            _Rigidbody.angularDrag = underWaterAngularDrag;
        }
        else
        {
            _Rigidbody.drag = airDrag;
            _Rigidbody.angularDrag = airAngularDrag;
        }
    }//end switch
    
}//end class

