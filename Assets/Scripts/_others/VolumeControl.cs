using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public AudioSource AudioSource; // necesitamos un audiosource un slider y un estado 0 inicial.
    public Slider volumeControl;
    private float MusicVolume = 0f;

  private void Start()
    {
        
        AudioSource.Play(); // audiosource comienza reproduciendose.
        MusicVolume = PlayerPrefs.GetFloat("Volume"); // obtiene las preferencias y las guarda en musicvolume.
        AudioSource.volume = MusicVolume; // audiosource se ajustara a musicvolume.
        volumeControl.value = MusicVolume; // el slider sera el volumen de musicvolume.

    }

    void Update()
    {
        AudioSource.volume = MusicVolume; //audiosource reproduce el valor de Musicvolume, que empieza en 0 sino le tocamos el slider.
        PlayerPrefs.SetFloat("Volume", MusicVolume); // guardamos las preferencias aunque cambiemos la pantalla.
    }

    public void VolumeUpdate(float volume)
    {
        MusicVolume = volume; // musicvolume tendra un valor float, que controlaremos con el slider de la escena options en unity.
       
    }
}
