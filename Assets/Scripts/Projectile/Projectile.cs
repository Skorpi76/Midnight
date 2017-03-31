using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile : MonoBehaviour
{

    public float flySpeed;
    protected Rigidbody2D rb;
    protected Weapon weapon;

    // ===================================
    void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
        this.rb.velocity = this.transform.up * flySpeed;
    }


    // ===================================
    public void SetWeapon(Weapon weapon)
    {
        this.weapon = weapon;
    }

    // ===================================
    public virtual void OnCollisionEnter2D(Collision2D other)
    {
        OnCollision(other.gameObject);
        Destroy(this.gameObject);
    }
    protected virtual void OnCollision(GameObject obj)
    {
        Entity entity = obj.GetComponent<Entity>();
        if (entity != null)
        {
            this.weapon.OnHit(entity);
        }
    }


}