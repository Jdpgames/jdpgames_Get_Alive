using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemManager : MonoBehaviour
{
    public static ItemManager instance; // la instanciamos porque quiero acceder a ella desde otros scripts.
    public Text text;                   // texto que saldra en pantalla.
    public int score;                   // puntos que se tienen que actualizar.


    private void Start()
    {
       

        if (instance == null)
        {

            instance = this;

        }

    }
    public void changeScore(int coinValue)
    {
        score += coinValue;
        text.text = " " + score.ToString(); // conectamos score a Coinvalue.
        

    }


    void Update()
    {
        
    }

    public void AllItemCollected()
    {


        if (transform.childCount == 1) // cuando quede uno, me lanza un mensaje, este actual es de prueba.
        {
            Debug.Log(" objetivo Cumplido");

        }


    }

    public void checkWin()
    {

        if (transform.childCount == 0)                  /* aqui en esta funcion comprueba que si no quedan getalives y vamos a la puerta podemos ganar,
                                                           la puerta comprueba esta condicion, si se cumple que son 0, pasamos pantalla.*/
        {
            Debug.Log(" Level Complete");

            LevelManager.Instance.LevelComplete();
           

        }
        // si todavia quedan get alives, no te deja pasar en la puerta, lanza mensaje y sigues jugando.
        else if (transform.childCount >= 1)
        {
            Debug.Log(" objetivo no Cumplido, sigue jugando");

        }


    }





}
