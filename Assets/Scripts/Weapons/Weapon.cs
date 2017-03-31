using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public Transform shootPoint;
    protected int currentAmmunition;
    protected int maxAmmunition;
    protected float time;
    protected float coolDownTime;




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
    protected abstract void Shoot();
}
