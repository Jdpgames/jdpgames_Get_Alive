using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinalDoor : MonoBehaviour
{

    // al entrar el player en el trigger, que tiene el tag player, se cargará la escena MainMenu.
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {

            SceneManager.LoadScene("Creditos");

        }
    }
}
