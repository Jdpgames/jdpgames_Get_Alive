﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ioc.getAlive.Managers;
using ioc.getAlive.Core;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelManager : Singleton<LevelManager>
{ 
    public int Score;
    public int EnemiesKilled;
    public GameObject panelPause;
    public static bool GameIspaused = false;
    public GameObject panelLevelReport;
    public Text score;
    public Text Enemies;
    
    
   




    void Start()
    {
        Score = 0;
       
       
       panelLevelReport.SetActive(false);
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

    public void contadorFinal()
    {
       

        score.text = Score.ToString();
        Enemies.text = EnemiesKilled.ToString();

       


       
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
        // todavia no la implemento.
    }

   


    public void PlayerDead()
    {
      

        GameManager.Instance.ToGameOver();
    }

    public void LevelComplete()
    {
        panelLevelReport.SetActive(true);


        GameManager.Instance.inGame2();

       
    }
}
