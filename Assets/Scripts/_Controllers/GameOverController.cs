using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverController : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    // al pulsar el boton jugar de nuevo, nos carga el nivel 1.
    public void JugarDeNuevo()
    {

        SceneManager.LoadScene("Level01");

    }

    // al pulsar el boton salir, nos carga el menu principal.
    public void Salir()
    {
        SceneManager.LoadScene("MainMenu");
      
    }



}
