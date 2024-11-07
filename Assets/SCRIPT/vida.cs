using UnityEngine;

public class Vida : MonoBehaviour
{
    public int vida = 100;

    public void RecibirDanio(int cantidad)
    {
        vida -= cantidad;
        Debug.Log("Recibió daño. Vida restante: " + vida);

        if (vida <= 0)
        {
            // Acción cuando la vida llega a cero
            Muerte();
        }
    }

    void Muerte()
    {
        // Lógica para la muerte del personaje
        Debug.Log("Personaje ha muerto.");
        // Puedes agregar aquí efectos, reiniciar el nivel, etc.
    }
}
