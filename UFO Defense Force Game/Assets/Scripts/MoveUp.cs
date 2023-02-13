using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{

    public float moveSpeed = 1.0f;

    public float upperBound = -12;

    public int playerScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Make the balloon float upward
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

        if(transform.position.z < -12)
        {
            playerScore += 100;
            Destroy(gameObject);
            Debug.Log("Score: " + playerScore);
        }
    }
}
