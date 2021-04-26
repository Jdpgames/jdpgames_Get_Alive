using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCollision : MonoBehaviour
{

    // cantidad de daño que le genera al player al colisionar la bomba.
    public int CantidadDaño = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            PlayerHealth.instance.RestarVida(CantidadDaño);
            Destroy(gameObject); // despues de restar vida desaparece.

        }
        else Destroy(gameObject); // si no colisiona con player desaparece al caer al suelo.
    }
}
