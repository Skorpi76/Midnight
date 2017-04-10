using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDamageOverTime : MonoBehaviour
{
    public int amount;
    private bool canDamage = true;
    private AudioSource damageTakingSound;
 

    void Start()
    {
        damageTakingSound = GetComponent<AudioSource>();
    }
    public void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.GetComponent<Entity>() == true)
        {
            if (canDamage)
            {
                if (collider.gameObject.name == "Player")
                {
                    damageTakingSound.Play();
                }

                collider.GetComponent<Entity>().ModifyHealth(amount);
                canDamage = false;
                StartCoroutine(CanDamage());
            }

        }


    }
    IEnumerator CanDamage()
    {
        yield return new WaitForSeconds(1);
        canDamage = true;
    }
   
}
