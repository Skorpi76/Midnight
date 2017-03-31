using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDettect : MonoBehaviour {
    EnemyMove enemyMove;


    // ===================================
    void Start () {
        enemyMove = transform.parent.GetComponent<EnemyMove>();
	}

    // ===================================
    void OnTriggerEnter2D(Collider2D player)
    {
        enemyMove.IsPlayerNear(true);
    }

    // ===================================
    void OnTriggerExit2D(Collider2D player)
    {
        enemyMove.IsPlayerNear(false);
    }
}
