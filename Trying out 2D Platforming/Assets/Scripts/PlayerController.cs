using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [Header("Player Stats")]
    
    public float speed;

    public float jumpForce;

    public float moveInput;


    [Header("Rigidbody Components")]

private Rigidbody2D rb;

public bool isFacingRight = true;

[Header("Player Jump Settings")]

private bool isGrounded = true;

public Transform groundCheck;

public float checkRadius;

public LayerMask putGroundHere;

public bool doubleJump;

[Header ("Animations")]

private Animator playerAnim; //calls the animator
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
    }



    void FixedUpdate()
     {     
        if(moveInput > 0 || moveInput < 0)
            {
                playerAnim.SetBool("isWalking", true);
            }
            else
            {
                playerAnim.SetBool("isWalking", false);
            }
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, putGroundHere);

            moveInput = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
            playerAnim.SetBool("isWalking", true);


        if (!isFacingRight && moveInput > 0)
        {
            FlipPlayer();
        }
        else if(isFacingRight && moveInput < 0)
        {
            FlipPlayer();
        }
    }
    void FlipPlayer()
    {
        isFacingRight = !isFacingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
    // Update is called once per frame
    void Update()
    {
         
        //split here

        if(isGrounded)
        {
            doubleJump = true;
        }
        if(Input.GetKeyDown(KeyCode.Space) && doubleJump)
        {
            rb.velocity = Vector2.up * jumpForce;
            doubleJump = false;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && !doubleJump && isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
            //playerAnim..SetTrigger("Jump_Trigx")
        }
    }
  


    //If your GameObject keeps colliding with another GameObject with a Collider, do something
   
}
