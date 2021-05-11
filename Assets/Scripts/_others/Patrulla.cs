using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrulla : MonoBehaviour
{
    private Rigidbody2D myrig; // ref del rigidbody que vamos a mover.
    public float speed; // variable a la velocidad que lo moveremos.
    public Animator AnimEnemy;
    public GameObject John;
    public AudioSource MyAudio;
    void Start()
    {
        myrig = GetComponent<Rigidbody2D>(); // vinculamos.
        MyAudio.Stop();
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        myrig.velocity = new Vector2(-speed, myrig.velocity.y); // de inicio se movera para la izquierda.
        if (John != null) // si no muere, cumple esto.
        {

            float distanceX = Mathf.Abs(John.transform.position.x - transform.position.x); // calculamos la posicion entre john y este enemigo, en X y Y.
            float distanceY = Mathf.Abs(John.transform.position.y - transform.position.y);

            if (distanceX < 1.0f && distanceY < 1.0f ) // si el rango en X es inferior a 1 y en Y a 4  y ha cumplido el coldDown, dispara.
            {
                StartCoroutine("shoot");

                
            }
        }
    }

    IEnumerator shoot()
    {
        MyAudio.Play();
        AnimEnemy.SetBool("Fire", true);
        yield return new WaitForSeconds(0.50f);
        MyAudio.Stop();
        AnimEnemy.SetBool("Fire", false);
    }



    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Suelo") // cuando deja de detectar suelo, multiplicamos su direccion por negativo para girarlo en el otro sentido.
        {

            speed *= -1;
            this.transform.localScale = new Vector2(this.transform.localScale.x * -1, this.transform.localScale.y);

        }

    }

}

