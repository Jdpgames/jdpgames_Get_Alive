using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOut : MonoBehaviour
{
    public AudioSource myAudio;


    void Start()
    {
        
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if (collision.CompareTag("Player"))
        {
            myAudio.Stop();

        }
    }
}
