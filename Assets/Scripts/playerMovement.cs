using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float movementSpeed;
    private Rigidbody rb;
    public float jumpforce;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //movement code
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }
       else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.TransformDirection(Vector3.right) * Time.deltaTime * movementSpeed;
        }

        //jump code
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);

        }
    }
}
