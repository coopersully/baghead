using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementYetAgain : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;

    public float speed = 10f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;

    //Enforce laws of gravity
    public float gravity = -9.81f;
    Vector3 velocity;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    //Call for animation change based on walkspeed
    private Animator anim;
    private float walkspeed;

    void Start()
    {
        //get component from animator under child mesh
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        //Jump mechanic and triggers isJumping animation
        if (Input.GetKey("w") && isGrounded)
        {
           anim.SetBool("isJumping", true);
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        //Trigger forward jog animation
        else if (Input.GetKey("a") || Input.GetKey("d"))
        {
            anim.SetBool("isJogging", true);
            anim.SetBool("isJumping", false);
        }
        else
        {
           anim.SetBool("isJogging", false);
           anim.SetBool("isJumping", false);
        }

        //move and enforce laws of gravity
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        if (direction.magnitude >= 0.1f && !Input.GetKey("s") && !Input.GetKey("w"))
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 movDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(movDir.normalized * speed * Time.deltaTime);
        }
    }
}
