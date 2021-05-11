﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemManager : MonoBehaviour
{
    public static ItemManager instance; // la instanciamos porque quiero acceder a ella desde otros scripts.
    public Text text; // texto que saldra en pantalla.
    public int score; // puntos que se tienen que actualizar.
    public Text Text_NoWin;
    public AudioSource MyAudio;
    private void Start()
    {
        Text_NoWin.gameObject.SetActive(false);
        if (instance == null)
        {

            instance = this;

        }

        MyAudio.Stop();

    }
    public void changeScore(int coinValue)
    {
        score += coinValue;
        text.text = " " + score.ToString(); // conectamos score a Coinvalue.
        MyAudio.Play();

    }

    void Update()
    {

    }

    public void AllItemCollected()
    {

        if (transform.childCount == 1) // cuando quede uno, me lanza un mensaje, este actual es de prueba.
        {
           

        }

    }

    public void checkWin()
    {

        if (transform.childCount == 0)
        /* aqui en esta funcion comprueba que si no quedan getalives y vamos a la puerta podemos ganar,
                                                 la puerta comprueba esta condicion, si se cumple que son 0, pasamos pantalla.*/
        {
            

            LevelManager.Instance.LevelComplete();

        }
        // si todavia quedan get alives, no te deja pasar en la puerta, lanza mensaje y sigues jugando.
        else if (transform.childCount >= 1)
        {
           
            Text_NoWin.gameObject.SetActive(true);

        }

    }

}
