using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 7f;
    public bool isGrounded;      
    public Transform groundCheck; 
    public float groundDistance = 0.4f; 
    public LayerMask groundMask; 

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
