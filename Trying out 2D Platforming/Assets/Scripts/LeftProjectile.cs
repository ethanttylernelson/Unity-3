using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftProjectile : MonoBehaviour
{
     public float speed = 30.0f;

    public int damage = 1;


    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.right * speed * 100 * Time.deltaTime;
        //transform.position = new Vector3(-10, 0, 0) * Time.deltaTime;
        //rb.velocity = transform.translate.(10, 0, 0) * speed * 100 * Time.deltaTime;

        
     
    }

    void OnTriggerEnter2D(Collider2D other) 
    
        {
            Enemy enemy = other.GetComponent<Enemy>();

            if(other.gameObject.CompareTag("Enemy"))
            {
                enemy.TakeDamage(damage);
            }
            Destroy(gameObject);

        }
}
