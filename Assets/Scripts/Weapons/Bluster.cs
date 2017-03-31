using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bluster : Weapon {
   
    // ===================================
    void Start()
    {
        maxAmmunition = 40;
        currentAmmunition = maxAmmunition;

        coolDownTime = .1f;
        time = coolDownTime;
        damage = -20;
    }

    // ===================================
 

}
