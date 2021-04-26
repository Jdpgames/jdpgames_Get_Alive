using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInside : MonoBehaviour
{
    public AudioSource myAudio; // referencia al audio source.

    private void Start()
    {
        myAudio.Stop(); // empezará apagado.
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // si entra player a este trigger reproduce el sonido del helicoptero.
        {
            myAudio.Play();

        }
    }
}
