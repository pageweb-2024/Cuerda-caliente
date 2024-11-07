using UnityEngine;

public class Vida : MonoBehaviour
{
    public int vida = 100;

    public void RecibirDanio(int cantidad)
    {
        vida -= cantidad;
        Debug.Log("Recibi� da�o. Vida restante: " + vida);

        if (vida <= 0)
        {
            // Acci�n cuando la vida llega a cero
            Muerte();
        }
    }

    void Muerte()
    {
        // L�gica para la muerte del personaje
        Debug.Log("Personaje ha muerto.");
        // Puedes agregar aqu� efectos, reiniciar el nivel, etc.
    }
}
