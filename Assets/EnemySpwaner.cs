using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpwaner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 1.5f; // Interval between enemy spawns
    public float minY = -4f; // Bottom boundary for enemy movement

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-3f, 3f); // Random X position within range
        Vector3 spawnPosition = new Vector3(randomX, transform.position.y, transform.position.z);
        GameObject newEnemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        newEnemy.GetComponent<EnemyController>().SetMovementBounds(minY); // Set movement boundary for the enemy
    }
}
