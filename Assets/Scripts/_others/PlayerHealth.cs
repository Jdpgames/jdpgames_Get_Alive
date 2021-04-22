using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerHealth : MonoBehaviour
{
    public GameObject[] Corazones; // array de los 3 corazones de la UI.
    public int vidaInicial = 3; // tu numero de vidas.
    

    void Start()
    {
        vidaInicial = 3; // empiezas con 3.
        
    }

   
    void Update()
    {

        if (vidaInicial < 2)
        {
            Destroy(Corazones[1].gameObject); // si vida es -2, destruye un corazon.

           
        }


        if (vidaInicial < 3)
        {
            Destroy(Corazones[2].gameObject); // si vida es -3, destruye un corazon.


        }


    }

    public void RestarVida(int cantidad)
    {
        vidaInicial -= cantidad; // funcion que llamamos desde otros scripts. resta 1 vida a la vida inicial.


        if (vidaInicial <= 0)
        {   // ultimo corazon de la UI que se destruye.
            Destroy(Corazones[0].gameObject);

            
            // si vidas es 0, activar Muerte
            Dead();
            

        }

    }

    public void Dead()
    {
        Destroy(gameObject); // destruimos a John y mandamos a llamar a level manager para avisarle que player esta muerto.
        LevelManager.Instance.PlayerDead();



    }








}
