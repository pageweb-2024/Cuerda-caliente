using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crdeits : MonoBehaviour
{
    public void menu()
    {
        SceneManager.LoadScene("menu incial");
    }

    public void game()
    {
        SceneManager.LoadScene("juego");
    }

}
