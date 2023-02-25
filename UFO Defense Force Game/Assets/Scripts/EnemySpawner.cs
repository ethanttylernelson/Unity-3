using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
public GameObject[] enemyPrefabs;

[SerializeField]
private float spawnRangeX = 17f;
[SerializeField]
private float spawnPosZ;
public string hardMode = "Hard Mode Activated";
private float startDelay = 2f;
private float spawnInterval = 2f;
public int shipsDestroyed;
public ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }
public void ShipDestroyed()
{
    void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.CompareTag("Blaster"))
            {
                shipsDestroyed += 1;
            }
        }
}
    void SpawnRandomEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        int enemyIndex = Random.Range(0, enemyPrefabs.Length);

        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex]. transform.rotation);

    }
    void HardMode()
    {
        if(shipsDestroyed > 20)
        {
            spawnInterval +=5;
        }
    }
    void Update() {
        {

            if (shipsDestroyed > 20)
            {
                HardMode();
            }
        }
    }

}
