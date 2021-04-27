using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using ioc.getAlive.Core;

namespace ioc.getAlive.Managers
{
    public class GameManager : PersistenSingleton<GameManager> // modo persistente para que no muera al cambiar de escena.
    {

        public enum GameState
        {
            splash,
            MainMenu,
            controles,
            inGame, // definimos los estados de las escenas, nos serviran para referirnos a ellos en los casos del switch.
            inGame2,
            gameOver,
            exit

        }

        protected override void Awake()
        {
            base.Awake();
        }

        protected void Update()
        {

        }

        // Creamos las funciones que nos serviran para referirnos desde otras clases, dentro tienen los casos del switch.
        public void ToSplash()
        {
            ChangeState(GameState.splash);

        }

        public void ToMainMenu()
        {
            ChangeState(GameState.MainMenu);

        }
        public void inGame()
        {
            ChangeState(GameState.inGame);

        }
        public void inGame2()
        {
            ChangeState(GameState.inGame2);

        }

        public void ToControls()
        {
            ChangeState(GameState.controles);

        }

        public void ToGameOver()
        {
            ChangeState(GameState.gameOver);

        }
        public void ToExit()
        {
            ChangeState(GameState.exit);

        }
        /* el switch es el gestor de las funciones, segun la funcion que esogemos llama a una corrutina o otra, gracias a los estados,
        que definimos antes */

        private void ChangeState(GameState newState)
        {
            switch (newState)
            {

                case GameState.splash:
                    StartCoroutine(Logo("Splash"));
                    break;

                case GameState.MainMenu:
                    StartCoroutine(Inicio("MainMenu"));
                    break;

                case GameState.inGame:
                    StartCoroutine(Cargar("Level01"));
                    break;
                case GameState.inGame2:
                    StartCoroutine(Cargar1("Level02"));
                    break;
               case GameState.controles:
                    StartCoroutine(CargarControles("Controles"));
                    break;

                case GameState.gameOver:
                    StartCoroutine(cargarGameOver("GameOver"));
                    break;
                case GameState.exit:
                    Application.Quit();
                    break;

            }
            // las corrutinas estan conectadas al cambio de escena a la que nos queremos dirigir.
            IEnumerator Logo(string logo)
            {
                yield
                return new WaitForSeconds(1.0f);
                SceneManager.LoadScene("Splash");

            }

            IEnumerator Inicio(string inicio)
            {
                yield
                return new WaitForSeconds(1.0f);
                SceneManager.LoadScene("MainMenu");

            }

            IEnumerator Cargar(string cargar)
            {
                yield
                return new WaitForSeconds(1.0f);
                SceneManager.LoadScene("Level01");

            }

            IEnumerator Cargar1(string cargar)
            {
                yield
                return new WaitForSeconds(4.0f);
                SceneManager.LoadScene("Level02");

            }


            IEnumerator CargarControles(string cargarOpt)
            {
                yield
                return new WaitForSeconds(1.0f);
                SceneManager.LoadScene("Controles");

            }

            IEnumerator cargarGameOver(string cargarGameO)
            {
                yield
                return new WaitForSeconds(2.5f);
                SceneManager.LoadScene("GameOver");

            }

        }

    }

}