using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void Retry() {
        SceneManager.LoadScene("level", LoadSceneMode.Single);     
    }

    public void Exit()
    {
        Application.Quit();       
    }

    // Update is called once per frame
    void Update () {
		
	}
}
