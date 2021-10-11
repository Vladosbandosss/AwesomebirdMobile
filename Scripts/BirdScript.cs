using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private float moveSpeed = 3.5f;
    private bool moveLeft;

    private Animator anim;
    private float firstJumpForce = 6f;
    private float secondJumpForce = 8f;
    private bool firstJump;
    private bool secondJump;

    bool canPlay;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

        anim = GetComponent<Animator>();
    }

    private void Start()
    {
        firstJump = true;
        secondJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManger.instance.isGameStafrted)
        {
            MoveBird();

            if (Input.GetMouseButtonDown(0))
            {
                Jump();
            }
        }
       
    }
    void MoveBird()
    {
        if (moveLeft)
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            sr.flipX = true;
        }
        else
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            sr.flipX = false;
        }
    }

    void Jump()
    {
        if (firstJump)
        {
            firstJump = false;
            rb.velocity = new Vector2(rb.velocity.x, firstJumpForce);
            anim.SetTrigger("Fly");
        }

        else if (secondJump)
        {
            secondJump = false;
            rb.velocity = new Vector2(rb.velocity.x, secondJumpForce);
            anim.SetTrigger("Fly");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Border")
        {
            moveLeft = !moveLeft;
          
        }

        if (collision.gameObject.tag == "Ground")
        {
            if (rb.velocity.y <= 1)
            {
                firstJump = true;
                secondJump = true;
            }
           
        }
        
    }
}
