using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    private Rigidbody2D myhrb;
    public float speed;
    void Start()
    {
        myhrb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        myhrb.velocity = transform.up * -speed;
        Destroy(gameObject, 5f);

    }
}
