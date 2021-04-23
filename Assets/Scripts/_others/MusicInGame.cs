using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicInGame : MonoBehaviour
{
    public static MusicInGame instance;

    public AudioClip AudioClipInGame1;
    public AudioSource myAudio;

    private void Awake()
    {
        if (MusicInGame.instance == null) 
        {
            MusicInGame.instance = this; 
        }
        else if (MusicInGame.instance != this) 
        {
            Destroy(gameObject);
        }
    }

   


    public void AudioInGame()
    {
        PlayAudioClip(AudioClipInGame1); // reproduir l'audioclip seleccionat
    }







    public void PlayAudioClip(AudioClip audioClip) //amb aquesta funció ens estalviem fer una funció de reproducció per a cada clip, amb una podem reproduïr tots els sons.
    {
        myAudio.clip = audioClip;
        myAudio.Play();
    }










}
