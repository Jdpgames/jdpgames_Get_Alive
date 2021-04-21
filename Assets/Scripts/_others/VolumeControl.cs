using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public AudioSource AudioSource;
    public Slider volumeControl;
    private float MusicVolume = 0f;

    private void Start()
    {
        AudioSource.Play();
        MusicVolume = PlayerPrefs.GetFloat("Volume");
        AudioSource.volume = MusicVolume;
        volumeControl.value = MusicVolume;


    }

    // Update is called once per frame
    void Update()
    {
        AudioSource.volume = MusicVolume;
        PlayerPrefs.SetFloat("Volume", MusicVolume);
    }

    public void VolumeUpdate(float volume)
    {
        MusicVolume = volume;


    }
}
