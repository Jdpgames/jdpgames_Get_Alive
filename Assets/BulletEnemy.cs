using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    private Rigidbody2D BulletRgb;
    public float speed;

    void Start()
    {
        BulletRgb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        BulletRgb.velocity = transform.right * -speed;
        Destroy(gameObject, 5);
    }
}
