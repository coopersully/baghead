using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDeath : MonoBehaviour
{
    private string lastHit;
    private Rigidbody rb;
    public GameObject myGameObject;

    //punch variables
    public Vector3 collision = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        
    }

    public void Update()
    {
        //Ray myRay = new Ray(transform.position, new Vector3 (100f, 0f, 0f));
        RaycastHit hit;
        //Physics.Raycast(myRay, out hit);

        //Debug.DrawLine(transform.position, new Vector3(100f, 0f, 0f), Color.black);

        if (Physics.Raycast(transform.position, new Vector3(100f, 0f, 0f), out hit, 6))
        {
            Debug.DrawRay(transform.position, new Vector3(100f, 0f, 0f));
            if (Input.GetKey(KeyCode.Space))
            {
                Destroy(myGameObject);
            }
        }
    }
}
