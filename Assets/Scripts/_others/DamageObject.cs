using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour
{
    public int CantidadDaño = 1;
    public Transform spawnPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Player"))
        {
            other.GetComponent<PlayerHealth>().RestarVida(CantidadDaño);
            other.transform.position = spawnPoint.position;

            //Destroy(other.gameObject);

        }

    }


    }
