using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bluster : Weapon {
    public GameObject blusterPRFB;
    // ===================================
    void Start()
    {
        maxAmmunition = 40;
        currentAmmunition = maxAmmunition;

        coolDownTime = .1f;
        time = coolDownTime;
    }

    // ===================================
    protected override void Shoot()
    {
        Instantiate(blusterPRFB, shootPoint.position, shootPoint.rotation);
    }

}
