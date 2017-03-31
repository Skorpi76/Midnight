using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : Projectile
{
    public GameObject explosionPRFB;    
    public float explotionRadious = 1;
    protected override void OnCollision(GameObject obj)
    {
      
        Collider2D[] objects;

        objects = Physics2D.OverlapCircleAll(transform.position, explotionRadious);
        if (objects.Length != 0)
        {
            foreach (Collider2D o in objects)
            {
                base.OnCollision(o.gameObject);
            }
        }
        GameObject explosionObj =  (GameObject)Instantiate(explosionPRFB, transform.position, Quaternion.identity);
        Destroy(explosionObj, 1);
    }

}
