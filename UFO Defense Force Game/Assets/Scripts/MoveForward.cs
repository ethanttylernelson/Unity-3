using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public int shipsDestroyed;
   public EnemySpawner enemySpawner;
public float speed;
void Start() {
     enemySpawner = GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>();
}
void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.CompareTag("Blaster"))
            {
             enemySpawner.shipsDestroyed += 1;
            }
        }
    // Update is called once per frame
    void Update()
    {//literally makes it go forward
       transform.Translate(Vector3.forward * Time.deltaTime * speed); 
       

   }
       
    }
        
    

