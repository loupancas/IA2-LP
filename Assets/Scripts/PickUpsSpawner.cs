using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System;

public class PickUpsSpawner : MonoBehaviour
{
    public GameObject powerUpPrefab;
    public int numberOfPowerUps;
    public int minDistanceBetweenPowerUps;
    private Vector3 spawnAreaCenter;
    private Vector3 spawnAreaSize;
    public GameObject terrain;
    public PlayerSpawner playerSpawn;

    List<int> number = new List<int>();
    List<Vector3> existingspawnPoints = new List<Vector3>();


    void Start()
    {
        for (int i = 0; i < numberOfPowerUps; i++)
        {
            number.Add(i);
        }
        SpawnPowerUps();
    }

    void SpawnPowerUps()
    {
        List<Vector3> spawnPoints = number
        .Select(coordenadas => GetRandomSpawnPoint(minDistanceBetweenPowerUps, playerSpawn.startPosition))
        .ToList();

        spawnPoints.ForEach(spawnPoint =>
        {
            Instantiate(powerUpPrefab, spawnPoint, Quaternion.identity);
        });
    }

    Vector3 GetRandomSpawnPoint( float minDistance, Vector3 playerPosition)
    {
        spawnAreaCenter = new Vector3(terrain.transform.position.x, terrain.transform.position.y + 1, terrain.transform.position.z);
        spawnAreaSize = new Vector3(terrain.transform.localScale.x, 1, terrain.transform.localScale.z);

        Vector3 randomSpawnPoint;
        List<Vector3> existingSpawnPoints = existingspawnPoints;
        do
        {
            float randomX = UnityEngine.Random.Range(spawnAreaCenter.x - spawnAreaSize.x / 2, spawnAreaCenter.x + spawnAreaSize.x / 2);
            float randomY = UnityEngine.Random.Range(spawnAreaCenter.y - spawnAreaSize.y / 2, spawnAreaCenter.y + spawnAreaSize.y / 2);
            float randomZ = UnityEngine.Random.Range(spawnAreaCenter.z - spawnAreaSize.z / 2, spawnAreaCenter.z + spawnAreaSize.z / 2);

            randomSpawnPoint = new Vector3(randomX, randomY, randomZ);


        } while (existingSpawnPoints.Any(spawnPoint => Vector3.Distance(spawnPoint, randomSpawnPoint) < minDistance) || Vector3.Distance(randomSpawnPoint, playerPosition) < minDistance); ;


        return randomSpawnPoint;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(spawnAreaCenter, spawnAreaSize);
    }
}
