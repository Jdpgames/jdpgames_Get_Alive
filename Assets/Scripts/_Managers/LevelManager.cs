using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ioc.getAlive.Managers;
using ioc.getAlive.Core;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelManager : Singleton<LevelManager>
{
    public int Score; // variables para llevar el conteo de puntos.
    public int EnemiesKilled; // variables para llevar el conteo de enemigos abatidos.
    public GameObject panelPause; // referencia para el panelPausa.
    public static bool GameIspaused = false; // boleana para saber cuando estará pausado y no.
    public GameObject panelLevelReport; // // referencia para activar el panelLevelReport.
    public Text score; // texto que saldra por la UI del juego.
    public Text Enemies; // texto que saldra por la UI del juego.
    public AudioSource Audio;
    public AudioClip OpenMenu;
    void Start()
    {
        MusicInGame.instance.AudioInGame();

        Score = 0; // empezamos con 0 puntos y el panel de LevelReport Desactivado.

        panelLevelReport.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // MENU DE PAUSA

        if (GameIspaused)
        {
            panelPause.SetActive(true); // si esta pausado, el juego estara detenido y el panel de pausa estará activado.

            Time.timeScale = 0f;

        }
        else
        {
            panelPause.SetActive(false); // sino esta pausado, el juego estara en marcha y el panel de pausa estará desactivado.
            Time.timeScale = 1.0f;

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Audio.PlayOneShot(OpenMenu);
            GameIspaused = !GameIspaused; // si pulso escape, el operador logico dará el valor contrario de la operación.

        }

    }

    public void Continuar()
    {
        GameIspaused = !GameIspaused; // reanuda el juego y definimos que no estara pausado porque si no, nos sacaria el panel pausa al reanudar.

    }

    public void Reiniciar()
    {
        GameIspaused = !GameIspaused; // reinica el juego y definimos que no estara pausado porque si no, nos sacaria el panel pausa al reiniciar.
        GameManager.Instance.inGame();

    }

    public void Quit()
    {
        GameIspaused = !GameIspaused; // Salimos y vamos al menu principal y definimos que no estara pausado porque si no, nos sacaria el panelpausa en la escena de MainMenu.
        GameManager.Instance.ToMainMenu();

    }

    public void contadorFinal()
    {

        score.text = Score.ToString();
        Enemies.text = EnemiesKilled.ToString(); // conectamos Score, con las variables que se actualizan cuando abatimos enemigos.

    }

    public void sumarPuntos()
    {
        Score += 10; // si abato un enemigo +10
    }

    public void EnemyDead()
    {
        EnemiesKilled += 1; //cuento +1 el numero de enemigos abatidos.
    }

    public void Respawn()
    {
        // todavia no la implemento.
    }

    public void PlayerDead()
    {

        GameManager.Instance.ToGameOver(); // si el player muere, LevelManager le manda a cargar la escena gameover que la contiene el GameManager.
    }

    public void LevelComplete()
    {
        panelLevelReport.SetActive(true);

        GameManager.Instance.inGame2(); // si el player gana, LevelManager le manda a cargar la escena 2 que la contiene el GameManager.

    }
}
