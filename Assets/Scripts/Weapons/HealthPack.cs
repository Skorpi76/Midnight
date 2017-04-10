using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour {
    public int amount; 
    private GameObject player;
    private AudioSource grabHealthSound;
 
    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        grabHealthSound = GetComponent<AudioSource>();
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
                grabHealthSound.Play();
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
