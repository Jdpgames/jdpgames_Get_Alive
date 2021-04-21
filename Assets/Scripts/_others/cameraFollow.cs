using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject john;

   

    // Update is called once per frame
    void Update()
    { // posicion de john en x, altura 0 y -10 en profundidad. 
        if (john != null)
        {

            transform.position = new Vector3(john.transform.position.x, 0, -10);

        }
    }
}
