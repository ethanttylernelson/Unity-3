using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
public float scaleToIncrease = 0.1f;

    public int clickToPop = 3;

    public ScoreManager scoreManager; //References the score manager
public int scoreToGive = 100;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

void OnMouseDown()
{
clickToPop --;

transform.localScale += Vector3.one * scaleToIncrease;

if (clickToPop == 0)
{   
    scoreManager.IncreaseScoreText(scoreToGive);
     Destroy(gameObject);
}


}

}
