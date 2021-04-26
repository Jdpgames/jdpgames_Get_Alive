using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using ioc.getAlive.Core;

namespace ioc.getAlive.Controller
{
    public class SplashController : Singleton<SplashController>

    {
        protected void Start()
        { // llamamos a la corrutina.
            StartCoroutine("CargarMenu");
        }

        private void Update()
        {

        }

        // la corrutina espera 2 segundos y despues carga la escena MainMenu.
        IEnumerator CargarMenu()
        {
            yield
            return new WaitForSeconds(2.0f);

            SceneManager.LoadScene("MainMenu");

        }

    }
}