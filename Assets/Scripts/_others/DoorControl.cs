using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour
{
    // al entrar en el trigger el player, se comprobara en el script itemManager si cumple la condicion para ganar.
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {

            FindObjectOfType<ItemManager>().checkWin();

        }
    }
}
