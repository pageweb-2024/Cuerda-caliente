using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class juego : MonoBehaviour
{
    public void menu()
    {
        SceneManager.LoadScene("menu incial");
    }

    public void creditos()
    {
        SceneManager.LoadScene("creditos");
    }

}