using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using ioc.getAlive.Core;


namespace ioc.getAlive.Managers
{
  public class GameManager : PersistenSingleton<GameManager>
    { 
        public enum GameState
        {
            splash,
            MainMenu,
            inGame,
            inGame2,
            Options,
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



        public void ToOptions()
        {
            ChangeState(GameState.Options);

        }

        public void ToGameOver()
        {
            ChangeState(GameState.gameOver);

        }
        public void ToExit()
        {
            ChangeState(GameState.exit);

        }

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



                case GameState.Options:
                    StartCoroutine( CargarOptions("Options"));
                    break;

                case GameState.gameOver:
                    StartCoroutine(cargarGameOver("GameOver"));
                    break;
                case GameState.exit:
                    Application.Quit();
                    break;


            }

            IEnumerator Logo(string logo)
            {
                yield return new WaitForSeconds(1.0f);
                SceneManager.LoadScene("Splash");


            }

            IEnumerator Inicio (string inicio)
            {
                yield return new WaitForSeconds(1.0f);
                SceneManager.LoadScene("MainMenu");


            }

            IEnumerator Cargar (string cargar)
            {
                yield return new WaitForSeconds(1.0f);
                SceneManager.LoadScene("Level01");


            }

            IEnumerator Cargar1(string cargar)
            {
                yield return new WaitForSeconds(4.0f);
                SceneManager.LoadScene("Level02");


            }






            IEnumerator CargarOptions(string cargarOpt)
            {
                yield return new WaitForSeconds(1.0f);
                SceneManager.LoadScene("Options");

            }


            IEnumerator cargarGameOver(string cargarGameO)
            {
                yield return new WaitForSeconds(2.0f);
                SceneManager.LoadScene("GameOver");

            }





        }










    }



    
}