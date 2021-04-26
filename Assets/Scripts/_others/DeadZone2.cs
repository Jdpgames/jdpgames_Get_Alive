using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone2 : MonoBehaviour
{
    
    public Transform spawnPoint;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Player"))
        {
           
            other.transform.position = spawnPoint.position;


        }

    }
}
