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

    // Update is called once per frame
    void Update()
    {
        if (MueveObjetivo())
        {
            DirectionTarget = SiguienteTarget();
        }

        


    }

    private bool MueveObjetivo() // moviendome hacia el objetivo.
    {

        Vector2 distanceVector = patrolPoints[DirectionTarget].position - transform.position; // a que distancia estoy de el.

        if (distanceVector.magnitude<TargetDistance)
        {
           
            return true; // si hemos llegado al objetivo.
        }

       
        Vector3 velocityVector = distanceVector.normalized;
        transform.position += velocityVector * Patrolspeed * Time.deltaTime;
       
        return false;

    }


    private int SiguienteTarget()
    {
        mysprite.flipX = false;
        
        DirectionTarget++;
        


        if (DirectionTarget>=patrolPoints.Length)
        {
            mysprite.flipX = true;
            DirectionTarget = 0;

        }

        return DirectionTarget;
    }






}
