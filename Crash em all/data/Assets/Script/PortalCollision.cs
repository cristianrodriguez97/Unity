using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCollision : MonoBehaviour
{
    private PlayerControl playerControlScript; // Variable para almacenar el script PlayerControl
    private Rigidbody rb; // Variable para almacenar el Rigidbody del vehículo

    private Vector3 initialPosition = new Vector3(0, 0, -15); // La posición fija a la que queremos mover el objeto Vehicle
    private Quaternion initialRotation = Quaternion.identity; // La rotación fija a la que queremos mover el objeto Vehicle
    private Vector3 initialVelocity = Vector3.zero; // Velocidad deseada para el portal (en este caso, sin velocidad)


    private void OnCollisionEnter(Collision collision)
    {
        // Verifica si colisionamos con el objeto "Portal"
        if (collision.gameObject.CompareTag("Portal"))
        {
            // Obtener el componente PlayerControl del objeto Vehicle
            playerControlScript = GetComponent<PlayerControl>();
            // Desactivar el script
            playerControlScript.enabled = false;
            // Obtener el componente Rigidbody del objeto Vehicle
            rb = GetComponent<Rigidbody>();
            // Reiniciar la velocidad del objeto "Vehicle"
            rb.velocity = initialVelocity;
            // Mueve el objeto "Vehicle" a la posición fija del portal
            transform.position = initialPosition;
            // Reiniciar la rotación del objeto "Vehicle"
            transform.rotation = initialRotation;
            // Activar el script nuevamente
            playerControlScript.enabled = true;
        }
    }
}
