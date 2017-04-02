using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
         
public class RocketLauncher : Weapon
{
    
    // ===================================
    void Start()
    {
        maxAmmunition = 5;
        currentAmmunition = maxAmmunition;

        coolDownTime = .7f;
        time = coolDownTime;
        damage = -50;

        GameManager.current.weaponIcon.sprite = this.weaponIcon;
        GameManager.current.weponAmmo.text = this.currentAmmunition + "/" + this.maxAmmunition;
    }

    // ===================================


   
}
