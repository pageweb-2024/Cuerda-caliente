using UnityEngine;

public class CuerdaDeDa�o : MonoBehaviour
{
    public int damageAmount = 10; // Da�o que hace la cuerda

    // Este m�todo se llama cuando otro objeto con un Collider entra en contacto con la cuerda
    private void OnCollisionEnter(Collision collision)
    {
        // Verifica si el objeto con el que colisiona tiene la etiqueta "Jugador" o "Enemigo"
        if (collision.gameObject.CompareTag("Jugador") || collision.gameObject.CompareTag("Enemigo"))
        {
            // Obt�n el componente de la salud del personaje
            HealthBar healthBar = collision.gameObject.GetComponent<HealthBar>();
            if (healthBar != null)
            {
                // Aplica el da�o a la salud
                healthBar.TakeDamage(damageAmount);
            }
        }
    }

    // Si est�s usando triggers en lugar de colisiones f�sicas, usa OnTriggerEnter en su lugar:
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


