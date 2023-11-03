using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemigo : MonoBehaviour
{
    public GameObject enemyPrefab; 
    private int spawnCount = 0; 
    public int maxSpawns = 4; 
    public float spawnInterval = 2f; 

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        if (spawnCount < maxSpawns)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            spawnCount++;
        }
        else
        {
            CancelInvoke("SpawnEnemy"); // Cancela la repetición del Invoke para detener los spawns.
        }
    }
}
