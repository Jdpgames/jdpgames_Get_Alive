using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkground : MonoBehaviour
{
    public static bool isGrounded;

    // una boleana para saber cuando esta tocando el suelo, lo ponemos en static para acceder desde otro script,
    // en este caso accedemos desde PlayerController.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false;
    }

}
