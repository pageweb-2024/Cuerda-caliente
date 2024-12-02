using UnityEngine;

public class RopeDamage : MonoBehaviour
{
    public int damage = 10; // Daño que la cuerda inflige

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Verifica que el objeto sea el jugador
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }
        }
    }
}



