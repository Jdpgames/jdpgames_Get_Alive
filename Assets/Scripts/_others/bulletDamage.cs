using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDamage : MonoBehaviour
{
    public int CantidadDaño = 1; // daño de la bala sera de 1 unidad.
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Enemy")) // al entrar en el trigger, si tiene el tag Enemy, le restará a su salud 1 de vida.
        {
            other.GetComponent<EnemyHealth>().RestarVidaEnemigo(CantidadDaño);

            


        }

    }




    }
