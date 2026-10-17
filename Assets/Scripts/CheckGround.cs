using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public bool isGrounded;

    // Se activa cuando el sensor ENTRA en contacto con el suelo
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
    }

    // Se activa cuando el sensor SALE del contacto con el suelo (Cambiado de Enter a Exit)
    private void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false;
    }
}
