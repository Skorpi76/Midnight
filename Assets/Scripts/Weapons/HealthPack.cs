using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour {
    public int amount; 
    private GameObject player;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
       
        if (collider.gameObject.name == "Player")
        {
            if (player.GetComponent<Entity>().health == player.GetComponent<Entity>().maxHealth)
            {
                return;
            }
            else
            {
                player.GetComponent<Entity>().ModifyHealth(amount);
                Destroy(this.gameObject);
            }
       
        }
    }
}
