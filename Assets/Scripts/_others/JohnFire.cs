using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JohnFire : MonoBehaviour
{
    public Transform Firepoint; // punto donde sale la bala.
    public GameObject bullet; // prefab para instanciar.
    private float ColdDown; // tiempo que tiene que pasar para poder disparar de nuevo.

    void Start()
    {

    }

    // si pulso enter instanciamos la bala. 
    void Update()
    {
        if (Input.GetKey("return") && Time.time > ColdDown + 0.50f) {
            Instantiate(bullet, Firepoint.position, Firepoint.rotation);
            sfx.instance.AudioJohnFire();

            ColdDown = Time.time;

        }

    }
}
