using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float xRange;
    [SerializeField]
    private int sceneToLoad;
 public ScoreManager scoreManager;
    // Start is called before the first frame update
void Start()
{
    scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
}
       

    // Update is called once per frame

         
                
          
    public Transform blaster;

    public GameObject laserBolt;
   
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
             Debug.Log("Game Over");
            SceneManager.LoadScene(sceneToLoad);
            }
            else if(other.gameObject.CompareTag("PowerUp"))
           {
            scoreManager.IncreaseScore(1000);
                Destroy(other.gameObject);
        
            }
   
    }
}