using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx : MonoBehaviour
{
    public static sfx instance; // instancio esta clase para poder acceder desde otros scripts.

    public AudioClip JohnFire;
    public AudioClip JohnHurt;
    public AudioClip JohnDead; // clips de los  efectos que necesite.
    public AudioClip EnemyFire;
    public AudioClip EnemyHurt;
    public AudioSource Effects; // el audiosource al que vamos a vincular.

    private void Awake()
    {

        if (sfx.instance == null)
        {
            sfx.instance = this;   // instanciamos la clase y aasi nos aseguramos que no habra 2 Musicingame.
        }
        else if (sfx.instance != this)
        {
            Destroy(gameObject);
        }


    }
    // Audios de player
    public void AudioJohnFire()
    {
        PlayAudioClip(JohnFire); // Funciones que reproducen los audios y los llamamos desde otras hojas.

    }

    public void AudioJohnHurt()
    {
        PlayAudioClip(JohnHurt);
    }
    public void AudioJohnDead()
    {
        PlayAudioClip(JohnDead);
    }

    // Audios de Enemy

    public void AudioEnenmyFire()
    {
        PlayAudioClip(EnemyFire);
    }

    public void AudioEnenmyHurt()
    {
        PlayAudioClip(EnemyHurt);
    }

    



    public void PlayAudioClip(AudioClip audioClip)  // Con esta funcion nos ahorraremos de hacer una función de reproducción por cada clip. 
    {
        Effects.clip = audioClip;
        Effects.Play();
        
    }



}
