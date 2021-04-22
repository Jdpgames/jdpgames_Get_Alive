using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrulla : MonoBehaviour
{
    private Rigidbody2D myrig;
    public float speed;

    void Start()
    {
        myrig = GetComponent<Rigidbody2D>();
    }
        // Update is called once per frame
        void Update()
        {

            myrig.velocity = new Vector2(-speed, myrig.velocity.y);


        }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag=="Suelo")
        {
            speed *= -1;
            this.transform.localScale = new Vector2(this.transform.localScale.x * -1, this.transform.localScale.y);
        }


    }

}

