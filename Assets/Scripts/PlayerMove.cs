using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    public float runSpeed=2;
    public float jumpSpeed = 3;
    public CheckGround checkGround; 
    Rigidbody2D rd2D;

    public SpriteRenderer spriteRenderer;

    public Animator animator;

    void Start()
    {
        rd2D = GetComponent<Rigidbody2D>();

        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
    }

    void FixedUpdate()
    {
        if(Input.GetKey("d") || Input.GetKey("right"))
        {
            rd2D.velocity = new Vector2(runSpeed, rd2D.velocity.y);
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);
        }

        else if(Input.GetKey("a") || Input.GetKey("left"))
        {
            rd2D.velocity = new Vector2(-runSpeed, rd2D.velocity.y);
            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);
        }
        else
        {
            rd2D.velocity = new Vector2(0, rd2D.velocity.y);
            animator.SetBool("Run", false);
        }
        if (Input.GetKey("space") && checkGround.isGrounded)
        {
           rd2D.velocity = new Vector2(rd2D.velocity.x, jumpSpeed); 
        }
        if (checkGround.isGrounded == false)
        {
            animator.SetBool("Jump", true);
            animator.SetBool("Jump", false);
        }
        if (checkGround.isGrounded == true)
        {
            animator.SetBool("Jump", false);
        }
    }
}