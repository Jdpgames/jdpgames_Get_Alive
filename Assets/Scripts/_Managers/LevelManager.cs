using System.Collections;
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
    public Text score;
    public Text Enemies;




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

    public void contadorFinal()
    {
       
        score.text = Score.ToString();
        Enemies.text = EnemiesKilled.ToString();




        // esto ya no me hace falta
        /*Debug.Log( score) ;
         Debug.Log(m_enemiesKilled);*/
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
