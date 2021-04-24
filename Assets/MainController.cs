using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ioc.getAlive.Managers;

public class MainController : MonoBehaviour
{



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
