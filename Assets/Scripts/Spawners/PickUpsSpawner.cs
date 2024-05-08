using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System;

public class PickUpsSpawner : MonoBehaviour
{
    public GameObject[] pickupPrefabs;
    public int minDistanceBetweenPowerUps;    
    public Transform spawnerParent;
    public Transform spawnerContainer;

    public PlayerSpawner playerSpawn;
    public float quantity;

    List<int> number = new List<int>();
    List<Vector3> existingspawnPoints = new List<Vector3>();
    int countPU;

    void Awake()
    {
        for (int i = 0; i < quantity; i++)
        {
            number.Add(i);
        }
        SpawnPowerUps();
        PlayerManager.instance.OpenPanel();
    }

    void SpawnPowerUps()
    {
        //IA2-LINQ 
        List<Vector3> spawnPoints = number
        .Select(coordenadas => GetRandomSpawnPoint(minDistanceBetweenPowerUps, playerSpawn.startPosition))
        .ToList();

        spawnPoints.ForEach(spawnPoint =>
        {
            GameObject pickupPrefab = pickupPrefabs[UnityEngine.Random.Range(0, pickupPrefabs.Length)];
            GameObject gobject =Instantiate(pickupPrefab, spawnPoint, Quaternion.identity,spawnerParent);
            gobject.name = countPU.ToString() + " " + gobject.name;
            countPU++;
        });
    }

    Vector3 GetRandomSpawnPoint( float minDistance, Vector3 playerPosition)
    {
        
        //IA2-LINQ 
        Vector3 randomSpawnPoint;
        List<Vector3> existingSpawnPoints = existingspawnPoints;
        do
        {
            float randomX = UnityEngine.Random.Range( -spawnerContainer.localScale.x / 2, spawnerContainer.localScale.x / 2);
            float randomY = 1f;
            float randomZ = UnityEngine.Random.Range( -spawnerContainer.localScale.z / 2, spawnerContainer.localScale.z / 2);

            randomSpawnPoint = new Vector3(randomX, randomY, randomZ);


        } while (existingSpawnPoints.Any(spawnPoint => Vector3.Distance(spawnPoint, randomSpawnPoint) < minDistance) || Vector3.Distance(randomSpawnPoint, playerPosition) < minDistance); ;

        existingSpawnPoints.Add(randomSpawnPoint);
        return randomSpawnPoint;
    }

   
}
