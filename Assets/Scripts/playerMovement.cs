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
    public float gravityEdit;

    private float jumpTimeCounter;
    public float jumpTime;
    private float doubleCounter;

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

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
            doubleCounter = Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position += transform.TransformDirection(Vector3.right) * Time.deltaTime * movementSpeed;
        }


        //jump code
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            jumpTimeCounter = jumpTime;
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime * gravityEdit;
            }
        }


        //jump height limit
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector3.up * jumpforce;
                jumpTimeCounter -= Time.deltaTime;
            }
        }

        //better jump code
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * (Physics.gravity.y * 2) * (fallMultiplier - 1) * Time.deltaTime * gravityIncreaser;
        }
    }
}