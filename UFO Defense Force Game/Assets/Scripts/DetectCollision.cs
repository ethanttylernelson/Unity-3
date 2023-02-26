using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager;
    public EnemySpawner enemySpawner;
    public int scoreToGive;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
         enemySpawner = GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>();
    }

    // Update is called once per fram
    void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.CompareTag("Blaster"))
            {
                Destroy(gameObject);
                Destroy(other.gameObject);
                scoreManager.IncreaseScore(scoreToGive);
            }

            

        }
        //Explosion();
            //scoreManager.IncreaseScore(scoreToGive);
            //Destroy(other.gameObject);
            //Destroy(gameObject);
    }

