using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrulla : MonoBehaviour
{
    private Rigidbody2D myrig; // ref del rigidbody que vamos a mover.
    public float speed; // variable a la velocidad que lo moveremos.

    void Start()
    {
        myrig = GetComponent<Rigidbody2D>(); // vinculamos.
    }
        // Update is called once per frame
        void Update()
        {

            myrig.velocity = new Vector2(-speed, myrig.velocity.y); // de inicio se movera para la izquierda.


        }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag=="Suelo") // cuando deja de detectar suelo, multiplicamos su direccion por negativo para girarlo en el otro sentido.
        {
            speed *= -1;
            this.transform.localScale = new Vector2(this.transform.localScale.x * -1, this.transform.localScale.y);
        }


    }

}

