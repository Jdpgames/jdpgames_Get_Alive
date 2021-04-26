using System.Collections;
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
        // si la posición de john llega a 72, camara dejara de seguirle, y se quedara fija en 72.1f
        if (john != null && john.transform.position.x > 72.0f) {

            transform.position = new Vector3(72.1f, 0, -10);

        }

    }
}
