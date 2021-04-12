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
        {
            StartCoroutine("CargarMenu");
        }


        private void Update()
        {

        }


        IEnumerator CargarMenu()
        {
            yield return new WaitForSeconds(2.0f);

            SceneManager.LoadScene("MainMenu");


        }





    }
}