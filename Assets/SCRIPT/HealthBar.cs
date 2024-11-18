using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthSlider; // Referencia al Slider (barra de vida)
    public int maxHealth = 100; // Salud máxima
    public int currentHealth; // Salud actual

    // Método para inicializar la salud
    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    // Método para recibir daño
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0) currentHealth = 0;
        UpdateHealthBar();
    }

    // Método para actualizar la barra de salud
    void UpdateHealthBar()
    {
        if (healthSlider != null)
        {
            healthSlider.value = (float)currentHealth / maxHealth;
        }
    }
}

