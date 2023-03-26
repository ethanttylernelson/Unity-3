using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyPatrol : MonoBehaviour
{
    public float speed;

    public float rayDistance;

    public bool isMovingRight = true;

    public Transform groundDetection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, rayDistance);

        if (groundInfo.collider == false)
        {
            if(isMovingRight == true)
            {
                //flip enemy at edge to move left
                transform.eulerAngles = new Vector3(0, -180, 0);
                isMovingRight = false;
            }
            else 
            {
                //flip enemy at edge to move right
                transform.eulerAngles = new Vector3(0,0,0);
                isMovingRight = true;
            }
        }
            
        }

    }


