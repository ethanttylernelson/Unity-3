using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager;
    public EnemySpawner enemySpawner;
    public int scoreToGive;
    public int score;
    public AudioClip explodeSound;
    public AudioSource blasterAudio;
    public ParticleSystem explosionParticle;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
         enemySpawner = GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>();
         blasterAudio = GetComponent<AudioSource>();
    }

    // Update is called once per fram
    void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.CompareTag("Blaster"))
            {
                Destroy(gameObject);
                Destroy(other.gameObject);
                scoreManager.IncreaseScore(scoreToGive);
                Explosion();
                blasterAudio.PlayOneShot(explodeSound,1.0f);
            }
               
            

        }
        void Explosion()//yay
        {
            Instantiate(explosionParticle, transform.position, transform.rotation);
            explosionParticle.Play();
        }


    }

