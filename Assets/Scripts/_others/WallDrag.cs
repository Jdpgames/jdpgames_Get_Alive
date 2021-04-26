using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDrag : MonoBehaviour
{
    public AudioSource myAudio; // audiosource al que nos referimos.
    private float ColdDown; // tiempo que tiene que estar colisionando.

    private void Start()
    {
        myAudio.Stop(); // empiezas parado.

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player" && Time.time > ColdDown + 1f) {
            myAudio.Play(); // si el player colisiona durante 1 segundo me reproduce este audio.
            Destroy(gameObject, 4.5f);
            ColdDown = Time.time; // Coldown sera el tiempo que pasa, time. time va contando el tiempo.

        }
    }

}
