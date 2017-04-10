using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Sprite weaponIcon;
    public Transform shootPoint;
    public GameObject projectilePRFB;
    protected int currentAmmunition;
    protected int maxAmmunition;
    protected float time;
    protected float coolDownTime;
    protected int damage;
    public enum AmmoType {BLASTER, ROCKET}
    public AmmoType ammotype;


    void OnEnable() {
        if (GameManager.current != null)
        {
            GameManager.current.weaponIcon.sprite = this.weaponIcon;
            GameManager.current.weponAmmo.text = this.currentAmmunition + "/" + this.maxAmmunition;
        }
     
    }

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
                GameManager.current.weponAmmo.text = this.currentAmmunition + "/" + this.maxAmmunition;
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

    public bool AddAmmo(int amount)
    {
        if (maxAmmunition == this.currentAmmunition)
        {
            return false;
        }
        else
        {
            currentAmmunition += amount;
            if (currentAmmunition > maxAmmunition)
            {
                this.currentAmmunition = this.maxAmmunition;
            }
            GameManager.current.weponAmmo.text = this.currentAmmunition + "/" + this.maxAmmunition;
            return true;
        }
    }

}
