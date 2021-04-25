using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCollision : MonoBehaviour
{
    public int CantidadDaño = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            PlayerHealth.instance.RestarVida(CantidadDaño);
            Destroy(gameObject);

           

            
        }

        else Destroy(gameObject);
    }
}
