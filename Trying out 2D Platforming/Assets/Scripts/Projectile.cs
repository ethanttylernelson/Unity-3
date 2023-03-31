using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed = 30.0f;

    public int damage = 1;

    private Rigidbody2D rb;

    public PlayerController player;

    public float rightBounds;

    public float leftBounds;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        if(player.isFacingRight == true)
        {
            rb.velocity = transform.right * speed * 100 * Time.deltaTime;
        }
        else if(player.isFacingRight == false)
        {
            rb.velocity = transform.right * -speed * 100 * Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
       if(transform.position.x > rightBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.x > leftBounds)
        {
            Destroy(gameObject);
        }
 
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
