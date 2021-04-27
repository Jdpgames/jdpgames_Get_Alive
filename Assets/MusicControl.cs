using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
    public AudioSource Control;

    public void ON() // Música encendida.
    {
        Control.Play();

    }

    public void OFF() // Música Apagada.
    {
        {
            Control.Stop();
        }
    }
}
