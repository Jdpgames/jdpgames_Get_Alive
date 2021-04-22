using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerHealth : MonoBehaviour
{
    public GameObject[] Corazones;
    public int vidaInicial = 3;
    



    void Start()
    {
        vidaInicial = 3;
        
    }

    // Update is called once per frame
    void Update()
    {



        if (vidaInicial < 2)
        {
            Destroy(Corazones[1].gameObject);

            



        }


        if (vidaInicial < 3)
        {
            Destroy(Corazones[2].gameObject);
           

        }


    }

    public void RestarVida(int cantidad)
    {
        vidaInicial -= cantidad;


        if (vidaInicial <= 0)
        {   // ultimo corazon de la UI
            Destroy(Corazones[0].gameObject);

            
            // activar Muerte
            Dead();
            // aqui puede ir una funcion con texto de gameOver y dos botones si quiere jugar

        }

    }

    public void Dead()
    {
        Destroy(gameObject);
        LevelManager.Instance.PlayerDead();



    }








}
