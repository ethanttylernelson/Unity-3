using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 35.0f;
    public float lowerBounds = -20.0f;
    
    private ScoreManager scoreManager; //references score manager

    private DetectCollision detectCollision;
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        detectCollision = GetComponent<DetectCollision>();
    }
    
    void Awake() 
{
    //Time.timeScale = 1;
}

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
            scoreManager.DecreaseScore(10);
            //Time.timeScale = 0;
        }
    }
}
