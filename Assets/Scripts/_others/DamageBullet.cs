using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBullet : MonoBehaviour
{ // la bala del enemigo quita 1 de vida
    public int CantidadDaño = 1;

    // si colisiona con el player,accede al script playerhealt y le resta 1 de vida. 
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
