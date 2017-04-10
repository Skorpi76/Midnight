using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPack : MonoBehaviour {
    public Weapon.AmmoType ammoType;
    public int amount;
    private AudioSource grabAmmoSound;
    void Start()
    {
        grabAmmoSound = GetComponent<AudioSource>();
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Player")
        {
            WeaponManager wm = collider.GetComponent<WeaponManager>();

            if (wm.AddAmmo(this.ammoType, this.amount))
            {
                grabAmmoSound.Play();
                StartCoroutine(WaitForSoundAndDestroy());
              
            }
        }
       
    }
    IEnumerator WaitForSoundAndDestroy()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }
}

