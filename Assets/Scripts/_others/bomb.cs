using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    private Rigidbody2D myhrb; // necesitamos un rigidbody al que referirnos, y una velocidad.
    public float speed;
    void Start()
    {
        myhrb = GetComponent<Rigidbody2D>(); // vinculamos al componente que tenga el script.
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myhrb.velocity = transform.up * -speed; // UP en negativo, quiere decir que caera para abajo la bomba.
        Destroy(gameObject, 5f); // despues de 5 segundos la bomba desaparece para ahorrar recursos.

    }
}
