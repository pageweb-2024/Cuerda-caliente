using UnityEngine;

public class CuerdaDeDaño : MonoBehaviour
{
    public int damageAmount = 10; // Daño que hace la cuerda

    // Este método se llama cuando otro objeto con un Collider entra en contacto con la cuerda
    private void OnCollisionEnter(Collision collision)
    {
        // Verifica si el objeto con el que colisiona tiene la etiqueta "Jugador" o "Enemigo"
        if (collision.gameObject.CompareTag("Jugador") || collision.gameObject.CompareTag("Enemigo"))
        {
            // Obtén el componente de la salud del personaje
            HealthBar healthBar = collision.gameObject.GetComponent<HealthBar>();
            if (healthBar != null)
            {
                // Aplica el daño a la salud
                healthBar.TakeDamage(damageAmount);
            }
        }
    }

    // Si estás usando triggers en lugar de colisiones físicas, usa OnTriggerEnter en su lugar:
     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Jugador") || other.gameObject.CompareTag("Enemigo"))
        {
            HealthBar healthBar = other.gameObject.GetComponent<HealthBar>();
            if (healthBar != null)
            {
                healthBar.TakeDamage(damageAmount);
            }
        }
     }
}


