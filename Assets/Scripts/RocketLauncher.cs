using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
         
public class RocketLauncher : Weapon
{
    public GameObject rocketPRFB;
    // ===================================
    void Start()
    {
        maxAmmunition = 5;
        currentAmmunition = maxAmmunition;

        coolDownTime = .2f;
        time = coolDownTime;
    }

    // ===================================
    protected override void Shoot()
    {
        Instantiate(rocketPRFB, shootPoint.position, shootPoint.rotation);
    }
}
