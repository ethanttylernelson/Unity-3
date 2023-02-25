using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float xRange;

    public Transform blaster;

    public GameObject laserBolt;

    public ScoreManager scoreManager;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //Vector3 means to be very specific
        //Time.deltaTime makes it run smooth
        //"right" means positive increase
        //"left means negative increase
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if(transform.position.x < -xRange )
        {
            //keeps the player within the bounds on the right
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        }
        if(transform.position.x > xRange )
        {
            //keeps the player within the bounds on the right
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
    }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserBolt, blaster.position, laserBolt.transform.rotation);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
         if(other.gameObject.CompareTag("Enemy"))
            {
             Time. timeScale = 0;
             Debug.Log("Game Over");
            }
    }
   
}