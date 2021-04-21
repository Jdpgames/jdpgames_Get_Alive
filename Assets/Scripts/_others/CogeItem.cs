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
            GetComponent<SpriteRenderer>().enabled = false;

            FindObjectOfType<ItemManager>().AllItemCollected();
            ItemManager.instance.changeScore(coinvalue);

            Destroy(gameObject);


        }

    }
}
