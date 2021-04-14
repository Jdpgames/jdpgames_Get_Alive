using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ioc.getAlive.Controller
{
    public class Player_Controller : MonoBehaviour
    {

        public float RunSpeed = 3;
        public float JumpSpeed = 5;
        Rigidbody2D rb2D;
        public SpriteRenderer mysprite;
        public Animator anim;


        void Start()
        {

            rb2D = GetComponent<Rigidbody2D>();


        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (Input.GetKey("d"))
            {
               rb2D.velocity = new Vector2(RunSpeed, rb2D.velocity.y);
                anim.SetBool("Run", true);
                transform.eulerAngles = new Vector3(0, 0, 0);

            }

            else if ( Input.GetKey("a"))
            {

                rb2D.velocity = new Vector2(-RunSpeed, rb2D.velocity.y);

                anim.SetBool("Run", true);
                transform.eulerAngles = new Vector3(0, 180, 0);


            }


            else
            {
                rb2D.velocity = new Vector2(0, rb2D.velocity.y);
                anim.SetBool("Run", false);
            }

            // si presiono la tecla enter dispara
            if (Input.GetKey("return"))
            {
                anim.SetBool("Fire", true);
                
            }

            else if (!Input.GetKey("return"))
            {
                anim.SetBool("Fire", false);
            }










            if (Input.GetKey("space")&& checkground.isGrounded)
            {
                rb2D.velocity = new Vector2(rb2D.velocity.x, JumpSpeed);


            }




            if (checkground.isGrounded==false)
            {
                anim.SetBool("Jump", true);
                anim.SetBool("Run", false);

            }

            else if (checkground.isGrounded==true)
            {
                anim.SetBool("Jump", false);
            }









        }
    }
}