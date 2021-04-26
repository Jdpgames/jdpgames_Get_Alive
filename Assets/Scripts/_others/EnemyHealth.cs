using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int vida = 1; // vida de enemigo.

    void Start()
    {
        vida = 1;

    }

    void Update()
    {

    }

    public void RestarVidaEnemigo(int cantidad)
    {
        vida -= cantidad;
        sfx.instance.AudioEnenmyHurt();

        if (vida <= 0)
        {

            Dead(); // si la vida es inferior a 0 activa la funcion dead.

        }

    }

    public void Dead()
    {
        LevelManager.Instance.sumarPuntos();
        LevelManager.Instance.EnemyDead(); // muere ( destroy) y  suma puntos + actualiza el contador del level report.
        LevelManager.Instance.contadorFinal();
        Destroy(gameObject);

    }

}