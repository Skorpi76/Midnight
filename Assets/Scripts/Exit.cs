﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Exit : MonoBehaviour {
    public static bool keyActive = false;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (keyActive)
        {
            SceneManager.LoadScene("GameOver");
            keyActive = false;
        }
    }
}
