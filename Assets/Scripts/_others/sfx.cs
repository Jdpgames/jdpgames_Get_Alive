using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx : MonoBehaviour
{
    public static sfx instance;

    public AudioClip JohnFire;
    public AudioClip JohnHurt;
    public AudioClip JohnDead;
    public AudioClip EnemyFire;
    public AudioClip EnemyHurt;

    public AudioSource Effects;

    private void Awake()
    {

        if (sfx.instance == null)
        {
            sfx.instance = this;
        }
        else if (sfx.instance != this)
        {
            Destroy(gameObject);
        }


    }
    // Audios de player
    public void AudioJohnFire()
    {
        PlayAudioClip(JohnFire);
        
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



    public void PlayAudioClip(AudioClip audioClip)  
    {
        Effects.clip = audioClip;
        Effects.Play();
        
    }



}
