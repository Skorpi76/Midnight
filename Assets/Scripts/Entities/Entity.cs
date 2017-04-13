using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour {
    public int maxHealth;
    public int health;
    public GameObject blood;

    // Use this for initialization
    void Start () {
        health = maxHealth;	
	}

    public virtual void ModifyHealth(int amount)
    {
       
        health += amount;
        if (health <= 0)
        {
            health = 0;
            OnDeath();
        }
        else if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
    public virtual void OnDeath()
    {
        Destroy(this.gameObject);
        if (blood != null)
        {
            Instantiate(blood,(new Vector3(transform.position.x, transform.position.y, 0f)), Quaternion.identity);
        }
    }

}
