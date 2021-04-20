using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Rigidbody2D bulletRgb;
    public float speed;
    void Start()
    {
        bulletRgb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bulletRgb.velocity = transform.right * speed * Time.deltaTime;

        Destroy(gameObject, 2);



    }
}
