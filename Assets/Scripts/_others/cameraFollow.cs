﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject john; // el objetivo que seguirá.

   

   
    void Update()
    { // camara seguira posicion de john en x, en altura 0 no se movera y en profundida estara en -10. 
        if (john != null) // siempre que john no este muerto.
        {

            transform.position = new Vector3(john.transform.position.x, 0, -10);

        }
    }
}