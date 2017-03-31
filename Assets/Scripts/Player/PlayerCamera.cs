using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {
    public float timeScale;
     private Transform player;
    private float zOffset;
    private Vector3 targetPosition; 

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        zOffset = 10;
	}
	
	// Update is called once per frame
	void Update () {
        if (player != null)
        {
            targetPosition = player.position + Vector3.back * zOffset;
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * timeScale);
        }
	}
}
