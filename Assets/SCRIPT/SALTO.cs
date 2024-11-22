using UnityEngine;

public class JumpController : MonoBehaviour
{
    public float jumpForce = 5f; // Fuerza del salto
    private Rigidbody rb;

    public AudioSource audioSource; // Referencia al componente AudioSource
    public AudioClip jumpSound;     // Sonido del salto

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
        if (audioSource != null && jumpSound != null) // Verifica si hay un AudioSource y un sonido asignado
        {
            audioSource.PlayOneShot(jumpSound); // Reproduce el sonido
        }
    }
}