using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVolador : MonoBehaviour

{
    public GameObject John;
    private float ColdDown;
    public Transform Firepoint2;
    public GameObject bullet;
    



    // Update is called once per frame
    void Update()
    {
        if (John != null)
        {

            float distanceX = Mathf.Abs(John.transform.position.x - transform.position.x);
            float distanceY = Mathf.Abs(John.transform.position.y - transform.position.y);

            if (distanceX < 1.0f && distanceY < 4.0f && Time.time > ColdDown + 0.75f)
            {
                shoot();

                ColdDown = Time.time;
            }
        }

        void shoot()
        {

            Instantiate(bullet, Firepoint2.position, Firepoint2.rotation);

        }


    }
}