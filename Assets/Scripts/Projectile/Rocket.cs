using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : Projectile
{
    public GameObject explosionPRFB;
    void OnCollisionEnter2D(Collision2D other)
    {
     
        GameObject explosionObj =  (GameObject)Instantiate(explosionPRFB, transform.position, Quaternion.identity);
        Destroy(explosionObj, 1);
        Destroy(this.gameObject);
    }

}
