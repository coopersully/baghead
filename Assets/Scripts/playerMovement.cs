using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float movementSpeed;
    private Rigidbody rb;

    //variables for jump
    public float jumpforce;
    public float fallMultiplier; //2.5
    public float lowJumpMultiplier; //2 
    public float gravityIncreaser;

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
        //better jump code
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime * gravityIncreaser;
        }

    }
}
