using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public float minSpawnRate = 1f;
    public float maxSpawnRate = 5f;
    public GameObject[] trashToBeSpawned;
    private float spawnRate = 0f;
    private Vector3 spawnLocation;

    IEnumerator SpawnTrash()
    {
        spawnLocation = new Vector3(Random.Range(0.0f, 150.0f), 5, Random.Range(0.0f, 150.0f));
        Instantiate(trashToBeSpawned[Random.Range(0, trashToBeSpawned.Length)], spawnLocation, Quaternion.identity);
        spawnRate = Random.Range(minSpawnRate, maxSpawnRate);
        yield return new WaitForSeconds(spawnRate);
        StartCoroutine(SpawnTrash());
    }
    
    void Start()
    {
        StartCoroutine(SpawnTrash());
    }

    void Update()
    {
        
    }
}
