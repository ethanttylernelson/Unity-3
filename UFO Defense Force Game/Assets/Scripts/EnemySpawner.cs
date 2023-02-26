using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemySpawner : MonoBehaviour
{
public GameObject[] enemyPrefabs;
 [SerializeField]
private int sceneToLoad;
[SerializeField]
private float spawnRangeX = 17f;
[SerializeField]
private float spawnPosZ;
private float startDelay = 2f;
private float spawnInterval = .3f;
public int shipsDestroyed;
public ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
        scoreManager.DecreaseScore(10000);
    }
void Update(){
    if (scoreManager.score >= 5000){
        Debug.Log("You Win!");
        SceneManager.LoadScene(sceneToLoad);

    }
}
    void SpawnRandomEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        int enemyIndex = Random.Range(0, enemyPrefabs.Length);

        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex]. transform.rotation);

    }


}
