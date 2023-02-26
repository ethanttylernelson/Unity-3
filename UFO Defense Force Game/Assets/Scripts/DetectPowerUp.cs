using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPowerUp : MonoBehaviour
{
    public ScoreManager scoreManager;
    // Start is called before the first frame update
void Start()
{
    scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
}
       

    // Update is called once per frame
     void OnCollisionEnter(Collision other) {
          if(other.gameObject.CompareTag("PowerUp"))
           {
            scoreManager.IncreaseScore(1000);
                Destroy(other.gameObject);
                
          }   
    }
}
