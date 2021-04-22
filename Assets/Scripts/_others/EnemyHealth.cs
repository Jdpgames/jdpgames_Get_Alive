using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int vida = 1;
    




    void Start()
    {
        vida = 1;

      

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestarVidaEnemigo(int cantidad)
    {
        vida -= cantidad;


        if (vida <= 0)
        {

            Dead();

            // muere y suma puntos + cuenta su muerte
          
            
        }

    }

    public void Dead()
    {
        LevelManager.Instance.sumarPuntos();
        LevelManager.Instance.EnemyDead();
        LevelManager.Instance.contadorFinal();
        Destroy(gameObject);




    }










}
