using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVolador : MonoBehaviour

{
    public GameObject John; // objetivo en el que fijarse.
    private float ColdDown; // tiempo entre disparo y disparo.
    public Transform Firepoint2; // punto donde se genera la bala.
    public GameObject bullet; // prefab de la bala que suelta.
    


    private void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (John != null) // si no muere, cumple esto.
        {

            float distanceX = Mathf.Abs(John.transform.position.x - transform.position.x);  // calculamos la posicion entre john y este enemigo, en X y Y.
            float distanceY = Mathf.Abs(John.transform.position.y - transform.position.y);

            if (distanceX < 1.0f && distanceY < 4.0f && Time.time > ColdDown + 0.75f) // si el rango en X es inferior a 1 y en Y a 4  y ha cumplido el coldDown, dispara.
            {
                shoot();

                ColdDown = Time.time;
            }
        }

        void shoot()
        {

            Instantiate(bullet, Firepoint2.position, Firepoint2.rotation); // instancia la bala.

        }


    }
}