using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour
{ // este script es para los objetos tipo sierra y pinchos, su funcion es restar 1 de vida y enviar a player a respawn.
    public int CantidadDaño = 1;
    public Transform spawnPoint;
    
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //  si el personaje entra en el trigger le quita 1 de vida y lo manda al spawnpoint.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Player"))
        {
            other.GetComponent<PlayerHealth>().RestarVida(CantidadDaño);

            
            other.transform.position = spawnPoint.position;


            //Destroy(other.gameObject);

        }

    }


}
