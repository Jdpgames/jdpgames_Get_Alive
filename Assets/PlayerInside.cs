using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInside : MonoBehaviour
{
    public AudioSource myAudio;



    private void Start()
    {
        myAudio.Stop();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            myAudio.Play();

        }
    }
}
