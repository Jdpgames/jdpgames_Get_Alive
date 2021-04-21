using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GameObject John;
    private float ColdDown;
    public Transform Firepoint1;
    public GameObject bullet;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (John!=null)
        {


            Vector2 direction = John.transform.position - transform.position;

            if (direction.x >= 0.0f) transform.eulerAngles = new Vector3(0, 180, 0);
            else transform.eulerAngles = new Vector3(0, 0, 0);

            float distanceX = Mathf.Abs(John.transform.position.x - transform.position.x);
            float distanceY = Mathf.Abs(John.transform.position.y - transform.position.y);

            if (distanceX <4.0f && distanceY<1.0f && Time.time>ColdDown + 0.50f)
            {
                shoot();

                ColdDown = Time.time;
            }






        }


        void shoot()
        {

            if (Time.time>ColdDown+0.50f)
            {
                Instantiate(bullet, Firepoint1.position, Firepoint1.rotation);





                ColdDown = Time.time;
            }


        }





        
    }
}
