using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMobile : MonoBehaviour
{
    public Transform posA, posB;
    public float speed = 2;
    public Transform startPos;
    Vector3 nexTpos;

    void Start()
    {
        nexTpos = startPos.position; 
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == posA.position)
        {

            nexTpos = posB.position;  // si llega al punto A, actualiza y se enfoca en ir a B.
        }

        if (transform.position == posB.position)
        {

            nexTpos = posA.position; 
        }

        transform.position = Vector3.MoveTowards( // vector 3, con nextpos sera la guia de hacia donde tiene que desplazarse.
          transform.position,
          nexTpos,
          speed * Time.deltaTime);

    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(posA.position, posB.position);
    }

}
