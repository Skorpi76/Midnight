﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject projectilePRFB;
    protected int currentAmmunition;
    protected int maxAmmunition;
    protected float time;
    protected float coolDownTime;
    protected int damage;




    void Update()
    {
        if (time < coolDownTime)
        {
            time += Time.deltaTime;

        }
        else if (Input.GetButton("Fire1"))
        {
            time = 0;
            if (currentAmmunition > 0)
            {
                Shoot();
                currentAmmunition--;
            }
   
        }
    }
    protected virtual void Shoot()
    {
        GameObject projectile =  Instantiate(projectilePRFB, shootPoint.position, shootPoint.rotation) as GameObject;
        projectile.GetComponent<Projectile>().SetWeapon(this);
    }
    public virtual void OnHit(Entity obj)
    {
        obj.ModifyHealth(damage);
    }
}
