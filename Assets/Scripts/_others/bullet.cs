using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Rigidbody2D bulletRgb; // necesitamos un rigidbody al que referirnos, y una velocidad.
    public float speed;
    void Start()
    {
        bulletRgb = GetComponent<Rigidbody2D>(); // vinculamos al componente rigidbody que tenga el script.
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bulletRgb.velocity = transform.right * speed * Time.deltaTime; // la bala se movera hacia la derecha.

        Destroy(gameObject, 2); // despues de 2 segundos se destruye.



    }
}
