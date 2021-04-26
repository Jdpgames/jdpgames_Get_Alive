using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ioc.getAlive.Managers;

public class MainController : MonoBehaviour
{
    public AudioSource Select;

    // Este script llama a funciones del GameManager que al presionar esos botones te lleva, esta en la escena MainMenu
    // pero también, la uso para otras escenas.
    public void Play()
    {
        Select.Play();
        GameManager.Instance.inGame();
    }

    public void options()
    {
        Select.Play();
        GameManager.Instance.ToOptions();
    }

    public void Controls()
    {
        Select.Play();
        GameManager.Instance.ToControls();
    }

    public void MainMenu()
    {

        GameManager.Instance.ToMainMenu();
    }

    public void Exit()
    {
        Select.Play();
        GameManager.Instance.ToExit();
    }

}