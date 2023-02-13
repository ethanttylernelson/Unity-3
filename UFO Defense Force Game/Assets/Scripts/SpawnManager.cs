using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] powerUpPrefabs;

    public int powerUpIndex;

    public float xSpawnRange;

    public float ySpawnPos;

    public float startDelay = 0.5f;

    public float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomPowerUp",startDelay,spawnInterval);
    }

   void SpawnRandomPowerUp()
   {
    //declare x spawn pos
    Vector3 spawnPos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), ySpawnPos, 17);
    //Pick a random prefab
    int powerUpIndex = Random.Range(-50, powerUpPrefabs.Length); 

    Instantiate(powerUpPrefabs[powerUpIndex], spawnPos, powerUpPrefabs[powerUpIndex].transform.rotation);
}
}
