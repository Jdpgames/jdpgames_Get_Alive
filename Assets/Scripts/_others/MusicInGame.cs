using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicInGame : MonoBehaviour
{
    public static MusicInGame instance; // instancio esta clase para poder acceder desde otros scripts.

    public AudioClip AudioClipInGame1; // clip de las musicas que necesite.
    public AudioSource myAudio; // el audiosource al que vamos a vincular.

    private void Awake()
    {
        if (MusicInGame.instance == null)
        {
            MusicInGame.instance = this; // instanciamos la clase y asi nos aseguramos que no habra 2 Musicingame.
        }
        else if (MusicInGame.instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void AudioInGame()
    {
        PlayAudioClip(AudioClipInGame1); // Funcion que reproduce el audio.
    }

    public void PlayAudioClip(AudioClip audioClip) // Con esta funcion nos ahorraremos de hacer una función de reproducción por cada clip. 
    {
        myAudio.clip = audioClip;
        myAudio.Play();
    }

}
