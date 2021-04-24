using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOut : MonoBehaviour
{
    public AudioSource myAudio;
    public AudioSource myAudio2;



    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if (collision.CompareTag("Player"))
            { 
           
                myAudio.Stop();

            myAudio2.Stop();


        }



      




    }
}
