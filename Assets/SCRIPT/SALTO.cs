using UnityEngine;

public class JumpController : MonoBehaviour
{
    public float jumpForce = 5f; // Fuerza del salto
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Obtiene el Rigidbody del personaje
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Si se presiona la barra espaciadora
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // Aplica una fuerza hacia arriba
    }
}
