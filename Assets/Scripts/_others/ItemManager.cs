using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemManager : MonoBehaviour
{
    public static ItemManager instance;
    public Text text;
    public int score;
    private void Start()
    {
        //int score = 3;

        if (instance == null)
        {

            instance = this;

        }

    }
    public void changeScore(int coinValue)
    {
        score += coinValue;
        text.text = " " + score.ToString();


    }


    
    void Update()
    {
        
    }

    public void AllItemCollected()
    {


        if (transform.childCount == 1)
        {
            Debug.Log(" objetivo Cumplido");

        }



    }

    public void checkWin()
    {

        if (transform.childCount == 0)
        {
            Debug.Log(" Level Complete");

            LevelManager.Instance.LevelComplete();
            // perfecto esto es el contador de puntos y enemigos abatidos.

           // LevelManager.Instance.contadorFinal();

            // despues de levelreport, invoca a la siguiente pantalla en 4 segundos.
            Invoke("pasaPantalla", 4);



            // esta ultima no me sirve ya.

            //Debug.Log(" Pasa Pantalla");
        }

        else if (transform.childCount >= 1)
        {
            Debug.Log(" objetivo no Cumplido, sigue jugando");

        }


    }


    void pasaPantalla()
    {

        LevelManager.Instance.LevelComplete();


    }



}
