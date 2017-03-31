using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile : MonoBehaviour
{

    public float flySpeed;
    protected Rigidbody2D rb;
    void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
        this.rb.velocity = this.transform.up * flySpeed;
    }


}