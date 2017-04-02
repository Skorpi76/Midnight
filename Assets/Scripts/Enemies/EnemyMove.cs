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
    public int damage = -10; 
    private float angle;
    private bool isAttacking; 
   

    // ===================================
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        isPlayerNear = false;
        isAttacking = false;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // ===================================
    void Update()
    {
        if (isPlayerNear && !this.isAttacking)
        {
            // Enemy Rotation
            enemyToPlayer = transform.position - player.position;
            angle = (Mathf.Atan2(enemyToPlayer.y, enemyToPlayer.x) * Mathf.Rad2Deg) + 90;
            transform.rotation = Quaternion.Euler(0, 0, angle);

            if (Vector3.Distance(this.transform.position, this.player.position) < 2)
            {
                StartCoroutine(Attack());
            }
        }

    }

    // ===================================
    IEnumerator Attack()
    {
        this.isAttacking = true;
        Vector3 originalPos = this.transform.position;
        Vector3 targetPos = this.player.position;
        float attackSpeed = 2f;
        float percent = 0f;
        float interpolation = 0;

        while (percent <= 1)
        {
            percent += Time.deltaTime * attackSpeed;
            interpolation = (-percent * percent + percent) * 4;
            transform.position = Vector3.Lerp(originalPos, targetPos, interpolation);

            yield return null;
        }
        player.GetComponent<Entity>().ModifyHealth(damage);
        yield return new WaitForSeconds(1f);
        this.isAttacking = false;
    } 


    // ===================================
    void FixedUpdate()
    {
        // Enemy Movement 
        if (isPlayerNear && !isAttacking)
        {
            body.velocity = transform.up * speed;
        }
        else
        {
            body.velocity = Vector3.zero;
        }
    }

    // ===================================
    public void IsPlayerNear(bool isNear)
    {
        isPlayerNear = isNear;
    }
}
