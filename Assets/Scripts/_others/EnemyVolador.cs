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

            // enemigo me mira
            Vector2 direction = John.transform.position - transform.position;

            if (direction.x >= 0.0f) transform.eulerAngles = new Vector3(0, 180, 0);
            else transform.eulerAngles = new Vector3(0, 0, 0);

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