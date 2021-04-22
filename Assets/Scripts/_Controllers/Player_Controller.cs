using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ioc.getAlive.Controller
{
    public class Player_Controller : MonoBehaviour
    {

        public float RunSpeed = 3; // necesitamos una variable para la  velocidad de movimiento.
        public float JumpSpeed = 5; // necesitamos otra para la velocidad de salto.
        Rigidbody2D rb2D; // la referencia del rigidbody al que nos vamos a referir.
        public Animator anim; // la referencia a su animator, para cambiar las animaciones.


        void Start()
        {

            rb2D = GetComponent<Rigidbody2D>(); // obtenemos el componente rigidbody.


        }

       
        void FixedUpdate() // porque nuestro personaje tiene fisica.
        { 
            if (Input.GetKey("d"))  
            {
               rb2D.velocity = new Vector2(RunSpeed, rb2D.velocity.y); // si pulsamos D, se movera a la derecha y en altura la dejamos por defecto.
                anim.SetBool("Run", true); // activamos la animacion Run.
                transform.eulerAngles = new Vector3(0, 0, 0); // mira hacia la derecha es decir no tocamos nada aun.

            }

            else if ( Input.GetKey("a"))
            {

                rb2D.velocity = new Vector2(-RunSpeed, rb2D.velocity.y); // si pulsamos A, se movera en negativo es decir la izq, altura no la tocamos.

                anim.SetBool("Run", true); // activamos la animacion Run.
                transform.eulerAngles = new Vector3(0, 180, 0); // para  mirar hacia la izquierda.


            }


            else
            {
                rb2D.velocity = new Vector2(0, rb2D.velocity.y); // sino pulsamos nada, no se mueve).
                anim.SetBool("Run", false); // no estara activa la animacion run, por lo tanto estara activo su idle.
            }

            // si presiono la tecla enter dispara
            if (Input.GetKey("return"))
            {
                anim.SetBool("Fire", true); // animación de disparar.
                
            }

            else if (!Input.GetKey("return"))
            {
                anim.SetBool("Fire", false); // sino se dispara, animación de disparar se desactiva.
            }










            if (Input.GetKey("space")&& checkground.isGrounded) // si pulsamos espacio y esta tocando el suelo salta(jumpspeed).
            {
                rb2D.velocity = new Vector2(rb2D.velocity.x, JumpSpeed);


            }




            if (checkground.isGrounded==false) // sino toca el suelo, activa anim Jump, y desactiva la anim run.
            {
                anim.SetBool("Jump", true);
                anim.SetBool("Run", false);

            }

            else if (checkground.isGrounded==true) // si toca el suelo, desactiva la animacion Jump.
            {
                anim.SetBool("Jump", false);
            }









        }
    }
}