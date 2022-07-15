using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnDelay = 5f;
    public float spawnTime;
    public Transform[] spawnPositions;
    public Enemy enemy;

    private void Start()
    {
        spawnTime = Time.time;
    }

    private void Update()
    {
        if(Time.time - spawnTime > spawnDelay)
        {
            spawnTime = Time.time;
            int spawnLoc = Random.Range(0, 4);
            Instantiate<Enemy>(enemy, spawnPositions[spawnLoc].position, transform.rotation);
            spawnDelay = spawnDelay > 1f ? spawnDelay -= .15f : spawnDelay;
        }    
    }
}
