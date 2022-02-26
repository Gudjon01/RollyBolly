using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawnRange = 8f;
    public int enemyCount;
    public GameObject enemy;
    void Start()
    {
        SpawnEnemy(1);
    }

    void Update()
    {

        enemyCount = FindObjectsOfType<EnemyController>().Length;
        if (enemyCount == 0 )
        {
            SpawnEnemy(3);
        }
    }

    private Vector3 SpawnEnemyLocation()
    {
        float spawnX = (Random.Range(-spawnRange, spawnRange));
        float spawnZ = (Random.Range(-spawnRange, spawnRange));
        Vector3 randomPos = new Vector3(spawnX, 0, spawnZ);
        return randomPos;
    }

    void SpawnEnemy(int enemySpawnCount)
    {
        for (int i = 0; i < enemySpawnCount; i++)
        {
            Instantiate(enemy, SpawnEnemyLocation(), enemy.transform.rotation);            
        }
    }
}
