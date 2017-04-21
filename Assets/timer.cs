using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

    float startTime;

	// Use this for initialization
	void Start () {
        startTime = Time.time;
		
	}
	
	// Update is called once per frame
	void Update () {
        TimeSpan timeSpan = TimeSpan.FromSeconds(Time.time - startTime);
        GetComponent<Text>().text =timeSpan.ToString();
	}
}
