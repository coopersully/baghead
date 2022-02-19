using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class betterJump : MonoBehaviour
{
    //variables for jump distances
    public float fallMultiplier; //2.5
    public float lowJumpMultiplier; //2 
    private Rigidbody rb;

    public void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
    }
}
