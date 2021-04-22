using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    private Rigidbody2D BulletRgb; // necesitamos un rigidbody al que referirnos, y una velocidad.
    public float speed;

    void Start()
    {
        BulletRgb = GetComponent<Rigidbody2D>(); // vinculamos al componente rigidbody que tenga el script.
    }

    // Update is called once per frame
    void Update()
    {
        BulletRgb.velocity = transform.right * -speed; //la dirección de la bala ira a la izquierda.
        Destroy(gameObject, 5); // depues de 5 segundos se destruira.
    }
}
