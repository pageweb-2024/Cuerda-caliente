using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuincial : MonoBehaviour
{
    public void EscenaJuego()
    {
        SceneManager.LoadScene("Juego");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
