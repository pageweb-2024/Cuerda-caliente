using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuerdaMovimiento : MonoBehaviour
{
    // Ajustes para el movimiento de la cuerda
    public float velocidadOscilacion = 2f;    // Velocidad del balanceo
    public float amplitudOscilacion = 30f;    // Amplitud del balanceo en grados
    public int damageAmount = 10;             // Cantidad de daño que inflige la cuerda

    private float tiempo;

    void Update()
    {
        // Movimiento de la cuerda
        tiempo += Time.deltaTime * velocidadOscilacion;
        float angulo = Mathf.Sin(tiempo) * amplitudOscilacion;

        // Rotar en el eje Y para un movimiento horizontal
        transform.rotation = Quaternion.Euler(angulo, 0f, 0f);
    }


}
