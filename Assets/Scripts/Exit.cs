using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Exit : MonoBehaviour {
    public static bool keyActive = false;

    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (keyActive)
        {
            if (coll.gameObject.name == "Player")
            {
                SceneManager.LoadScene("GameOver");
                keyActive = false;
            }
        }
    }
}
