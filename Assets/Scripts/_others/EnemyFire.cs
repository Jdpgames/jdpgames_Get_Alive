using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{   
    public GameObject John; // el target al que mirar.
    private float ColdDown; // tiempo que tiene que pasar para volver a disparar.
    public Transform Firepoint1; // punto donde se instancia la bala.
    public GameObject bullet; // el prefab que instanciamos.
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (John!=null) // si john no esta muerto, se cumple estas funciones.
        {


            Vector2 direction = John.transform.position - transform.position; //  distancia  de john que resta a la  del enemigo.

            if (direction.x >= 0.0f) transform.eulerAngles = new Vector3(0, 180, 0); // si es superior a 0 se voltea.
            else transform.eulerAngles = new Vector3(0, 0, 0); // sino, no.

            float distanceX = Mathf.Abs(John.transform.position.x - transform.position.x); // ubicamos la posicion de john y la restamos a la nuestra para saber la distancia.
            float distanceY = Mathf.Abs(John.transform.position.y - transform.position.y); // lo mismo pero el rango en Y.

            if (distanceX <4.0f && distanceY<1.0f && Time.time>ColdDown + 0.50f) // la condicion del rango, si esta a menos de 4 y de altura 1 y no hay coldown, funcion shoot que es disparar.
            {
                shoot();

                ColdDown = Time.time; // mando a cumplir la funcion shot y cuento el tiempo del coldDown.
            }






        }


        void shoot()
        {

            if (Time.time>ColdDown+0.50f) // si el tiempo ya es mayor a medio segundo instancia otra bala.
            {
                Instantiate(bullet, Firepoint1.position, Firepoint1.rotation);


                ColdDown = Time.time;
            }


        }





        
    }
}
