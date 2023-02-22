using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{

    public float moveSpeed = 1.0f;

    public float upperBound = -12;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other) {
        {
                if(other.gameObject.CompareTag("Player"))
            {
                Destroy(gameObject);
            }
        
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Make the balloon float upward
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

    }
}
