using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthSlider; // Referencia al Slider (barra de vida)
    public int maxHealth = 100; // Salud m�xima
    public int currentHealth; // Salud actual

    // M�todo para inicializar la salud
    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    // M�todo para recibir da�o
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0) currentHealth = 0;
        UpdateHealthBar();
    }

    // M�todo para actualizar la barra de salud
    void UpdateHealthBar()
    {
        if (healthSlider != null)
        {
            healthSlider.value = (float)currentHealth / maxHealth;
        }
    }
}

