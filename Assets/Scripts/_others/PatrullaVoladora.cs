using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrullaVoladora : MonoBehaviour
{
    
    public float Patrolspeed=0f; // velocidad patrullar.
    public float TargetDistance=0.1f; // distancia objetivo actual que hemos llegado.
    public Transform[] patrolPoints; // numero de puntos.
    int DirectionTarget = 0; // punto me estoy dirigiendo
    public SpriteRenderer mysprite;

    void Start()
    {
       
    }

   
    void Update()
    {
        if (MueveObjetivo()) // si esta moviendose para el objetivo y esta cerca, direccion del objetivo sera el nuevo objetivo.
        {
            DirectionTarget = SiguienteTarget();
        }

        


    }

    private bool MueveObjetivo() // moviendome hacia el objetivo.
    {

        Vector2 distanceVector = patrolPoints[DirectionTarget].position - transform.position; // resto mi posicion a la del target para saber a que distancia estoy de el punto.

        if (distanceVector.magnitude<TargetDistance)
        {
           
            return true; // si hemos llegado al objetivo devuelve true.
        }

       
        Vector3 velocityVector = distanceVector.normalized;
        transform.position += velocityVector * Patrolspeed * Time.deltaTime; // sino, seguirmos moviendonos haacia ese punto.
       
        return false;

    }


    private int SiguienteTarget() // cuando estamos volviendo para el siguiente target.
    {
        mysprite.flipX = false; // mientras no llegues no gira.
        
        DirectionTarget++; // una vuelta
        


        if (DirectionTarget>=patrolPoints.Length)
        {
            mysprite.flipX = true;  // al pasar por un punto entonces flipea. 
            DirectionTarget = 0; // si se queda a 0, reinicia las vueltas, para que este infinitamente entre 2 puntos y 0, al llegar a 0, vuelve a sumar hasta 2 etc...

        }

        return DirectionTarget; 
    }






}
