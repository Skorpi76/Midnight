using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public Weapon[] weapons;

    private int actualWeapon;

    void Start()
    {
        this.actualWeapon = 0;
        SwitchWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            if (actualWeapon != 0)
            {
                actualWeapon = 0;
                SwitchWeapon();
            }

        }
        else if (Input.GetKeyUp(KeyCode.Alpha2))
        {

            if (actualWeapon != 1)
            {
                actualWeapon = 1;
                SwitchWeapon();
            }
        }

    }

    void SwitchWeapon()
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            weapons[i].gameObject.SetActive(false);
        }
        weapons[actualWeapon].gameObject.SetActive(true);
    }
    public bool AddAmmo(Weapon.AmmoType type, int amount)
    {
        Weapon tmp = null;
        for (int i = 0; i < weapons.Length; i++)
        {
            if (weapons[i].ammotype == type)
            {
                tmp = weapons[i];
                i = weapons.Length;
            }
        }
        if (tmp != null)
        {
            return tmp.AddAmmo(amount);
        }
        else
        {
            return false;
        }
       
    }
}
