using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ioc.getAlive.Managers;

public class MainController : MonoBehaviour
{

    // Este script llama a funciones del GameManager que al presionar esos botones te lleva, esta en la escena MainMenu
    // pero también, la uso para otras escenas.
    public void Play()
    {

        GameManager.Instance.inGame();
    }

    public void options()
    {

        GameManager.Instance.ToOptions();
    }

    public void Controls()
    {

        GameManager.Instance.ToControls();
    }

    public void MainMenu()
    {

        GameManager.Instance.ToMainMenu();
    }

    public void Exit()
    {

        GameManager.Instance.ToExit();
    }

}