using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JohnFire : MonoBehaviour
{
    public Transform Firepoint;
    public GameObject bullet;
    private float ColdDown;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("return")&&Time.time>ColdDown +0.50f)
        {
            Instantiate(bullet, Firepoint.position, Firepoint.rotation);

            ColdDown = Time.time;

           


        }



    }
}
