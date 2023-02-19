using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }
       private void IncreaseScore()
        {
            score +=100;
            Debug.Log(score);
        }
    // Update is called once per fram
    void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.CompareTag("Blaster"))
            {
                Destroy(gameObject);
                Destroy(other.gameObject);
            }

        }
        //Explosion();
            //scoreManager.IncreaseScore(scoreToGive);
            //Destroy(other.gameObject);
            //Destroy(gameObject);
    }

