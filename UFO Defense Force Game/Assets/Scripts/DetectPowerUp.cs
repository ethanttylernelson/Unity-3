using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPowerUp : MonoBehaviour
{
    public int scoreToGive = 100;
    private int score;
    // Start is called before the first frame update

        private void IncreaseScore()
    {
        score = score + scoreToGive;
        Debug.Log(score);
    }

    // Update is called once per frame
     void OnCollisionEnter(Collision other) {
          if(other.gameObject.CompareTag("PowerUp")) {
                Destroy(other.gameObject);
                IncreaseScore();
          }   
    }
}
