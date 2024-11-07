using UnityEngine;

public class AutoJump : MonoBehaviour
{
    public float jumpForce = 5f;              // Fuerza del salto
    public float minJumpInterval = 1f;        // Intervalo m�nimo entre saltos
    public float maxJumpInterval = 3f;        // Intervalo m�ximo entre saltos
    private Rigidbody rb;
    private float nextJumpTime;
    private float currentJumpInterval;
    private bool isGrounded;                  // Verificaci�n de si est� en el suelo

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SetRandomJumpInterval();
        nextJumpTime = Time.time + currentJumpInterval;
    }

    void Update()
    {
        if (isGrounded && Time.time >= nextJumpTime)
        {
            Jump();
            SetRandomJumpInterval();
            nextJumpTime = Time.time + currentJumpInterval;
        }
    }

    void Jump()
    {
        if (rb != null)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
            isGrounded = false; // Asumimos que el objeto ya no est� en el suelo
        }
    }

    void SetRandomJumpInterval()
    {
        currentJumpInterval = Random.Range(minJumpInterval, maxJumpInterval);
    }

    void OnCollisionEnter(Collision other)
    {
        // Verifica si el objeto ha tocado el suelo
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
