﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDamage : MonoBehaviour
{
    public int CantidadDaño = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Enemy"))
        {
            other.GetComponent<EnemyHealth>().RestarVidaEnemigo(CantidadDaño);
            // si quiero que la bala se destruya al impactar: Destroy(gameObject);



        }

    }




    }
