using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Rigidbody2D body;
    private Transform player;
    private Vector3 enemyToPlayer;
    private bool isPlayerNear;
    public float speed; 
    private float angle;

    // ===================================
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        isPlayerNear = false;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // ===================================
    void Update()
    {
        if (isPlayerNear)
        {
            // Enemy Rotation
            enemyToPlayer = transform.position - player.position;
            angle = (Mathf.Atan2(enemyToPlayer.y, enemyToPlayer.x) * Mathf.Rad2Deg) + 90;
            transform.rotation = Quaternion.Euler(0, 0, angle);
          

        }

    }

    // ===================================
    void FixedUpdate()
    {
        // Enemy Movement 
        if (isPlayerNear)
        {
            body.velocity = transform.up * speed;
        }
        else
        {
            body.velocity = Vector2.zero;
        }
    }

    // ===================================
    public void IsPlayerNear(bool isNear)
    {
        isPlayerNear = isNear;
    }
}
