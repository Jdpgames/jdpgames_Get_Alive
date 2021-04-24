using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogeItem : MonoBehaviour
{
    
    public int coinvalue = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;// si el player entra en el triger, desactiva la imagen.
            
            FindObjectOfType<ItemManager>().AllItemCollected();// llama al itemManager para llevar la cuenta.
            ItemManager.instance.changeScore(coinvalue);//llama a itemManager para sumar 1 punto en el contador de la UI.
            
            Destroy(gameObject);//destruye el objeto recogido.


        }

    }
}
