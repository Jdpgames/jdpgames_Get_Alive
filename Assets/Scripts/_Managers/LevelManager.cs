using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ioc.getAlive.Managers;
using ioc.getAlive.Core;
public class LevelManager : Singleton<LevelManager>
{ 
    public int Score;
    public int EnemiesKilled;
    public GameObject panelPause;
    public static bool GameIspaused = false;





    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (GameIspaused)
        {
            panelPause.SetActive(true);

            Time.timeScale = 0f;


        }


        else
        {
            panelPause.SetActive(false);
            Time.timeScale = 1.0f;

        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {

            GameIspaused = !GameIspaused;

        }


        
    }


    public void Continuar()
    {
        GameIspaused = !GameIspaused;



    }

    public void Reiniciar()
    {
        GameIspaused = !GameIspaused;
        GameManager.Instance.inGame();

    }


    public void Quit()
    {
        GameIspaused = !GameIspaused;
        GameManager.Instance.ToMainMenu();


    }

    public void Opciones()
    {
        GameIspaused = !GameIspaused;
        GameManager.Instance.ToOptions();

    }



    public void sumarPuntos() {
        Score += 10;
    }



    public void EnemyDead()
    {
       EnemiesKilled += 1;
    }

    public void Respawn()
    {

    }


    public void PlayerDead()
    {
        //GameManager.Instance.ToGameOver();
    }

    public void LevelComplete()
    {
        //GameManager.Instance.
    }
}
