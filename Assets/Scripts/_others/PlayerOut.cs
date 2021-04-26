using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOut : MonoBehaviour
{
    public AudioSource myAudio; // referencia a dos audioSource que seran Helicoptero zona 1 y zona 2.
    public AudioSource myAudio2;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {

            myAudio.Stop(); // al entrar player en este trigger para los 2 audios de los helicopteros,
                            //es la zona 0 audio entre sala y sala.

            myAudio2.Stop();

        }

    }
}
