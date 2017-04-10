using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : Entity
{
    public GameObject[] content;
    public override void OnDeath()
    {
        // uncoment in case you want multiple items spawn 
        //int amount;
        Vector3 position = Vector3.back;

        //for (int i = 0; i < content.Length; i++)          
        //{
        // amount = Random.Range(0, 3);
        // for (int j = 0; j < amount; j++)
        // {
        int index = Random.Range(0, 2);
        position.x = Random.Range(-1f, 1f);
        position.y = Random.Range(-1f, 1f);
        Instantiate(content[index], this.transform.position + position, Quaternion.identity);
        Destroy(gameObject);

        // }
        // }

    }
}
