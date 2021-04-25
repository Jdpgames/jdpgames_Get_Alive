using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDrag : MonoBehaviour
{
    public AudioSource myAudio;
    public AudioClip pick;
    private float ColdDown;

    private void Start()
    {
        myAudio.Stop();
       
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player"&& Time.time > ColdDown + 1f)
        {
            myAudio.Play();

            ColdDown = Time.time;

            // animacion muro cayendo
           

        }
    }


   

}
