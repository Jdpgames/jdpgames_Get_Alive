using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBullet : MonoBehaviour
{ // la bala del enemigo quita 1 de vida
    public int CantidadDaño = 1;

    // si colisiona con el player,accede al script playerhealt y le resta 1 de vida. 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Player"))
        {
            other.GetComponent<PlayerHealth>().RestarVida(CantidadDaño);

        }

    }

}
