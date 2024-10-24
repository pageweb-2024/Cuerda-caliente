using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopePhysicsMovement : MonoBehaviour
{
    public float torque = 10f;  // Fuerza del torque
    private Rigidbody2D rb;

    void Start()
    {
        // Obtener el componente Rigidbody2D de la cuerda
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Aplicar torque a la cuerda para que gire
        rb.AddTorque(torque * Time.deltaTime);
    }
}
