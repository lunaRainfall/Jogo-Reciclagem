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
        GameObject trash;
        spawnLocation = new Vector3(Random.Range(0.0f, 150.0f), 11, Random.Range(0.0f, 150.0f));
        trash = Instantiate(trashToBeSpawned[Random.Range(0, trashToBeSpawned.Length)], spawnLocation, Quaternion.identity);
        trash.GetComponent<Rigidbody>().AddTorque(transform.right * Random.Range(40f, 300f));
        trash.GetComponent<Rigidbody>().AddTorque(transform.up * Random.Range(40f, 150f));
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
