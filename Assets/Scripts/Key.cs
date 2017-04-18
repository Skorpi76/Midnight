using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private GameObject exit;
    Exit exitScript;

    void Start()
    {
        exit = GameObject.Find("Exit");
        exitScript = exit.GetComponent<Exit>();
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Player")
        {
            Exit.keyActive = true;
            Destroy(this.gameObject);
        }
    }
}
