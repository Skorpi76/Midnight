using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundWhenPlayerInsideCollider : MonoBehaviour {

    private AudioSource fireSound;
    void Start()
    {
        fireSound = GetComponent<AudioSource>();
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Player")
        {
            fireSound.enabled = true;
            fireSound.Play();
        }
    }
    public void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Player")
        {
            fireSound.enabled = false;
        }
    }
}
