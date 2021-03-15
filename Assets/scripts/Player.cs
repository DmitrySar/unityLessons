using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    private Transform groundCheck;
    float speed = 5f;
    float jumpForce = 8f;
    private float radius = 0.1f;
    private string groundTag = "groundCheck";
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        groundCheck = GameObject.Find(groundTag).transform;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        flip();
    }

    private void FixedUpdate()
    {
        move();
        jump();
        stand();
    }

    void flip()
    {
        float axis = Input.GetAxis("Horizontal");
        if (axis < 0) spriteRenderer.flipX = true;
        if (axis > 0) spriteRenderer.flipX = false; 
    }

    void jump()
    {
        if (Input.GetAxis("Jump") > 0 && chekGround())
        {
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
            animator.SetInteger("state", 3);
        }
    }

    bool chekGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, radius);
        return colliders.Length > 1;
    }

    void move()
    {
        float axisX = Input.GetAxis("Horizontal");
        if (Input.GetAxis("Jump") == 0 && axisX !=0 && chekGround())
        {
            rb.velocity = new Vector2(axisX * speed, rb.velocity.y);
            animator.SetInteger("state", 2);
        }
    }

    void stand()
    {
        if (Input.GetAxis("Jump") == 0 && Input.GetAxis("Horizontal") == 0 && chekGround())
        {
            animator.SetInteger("state", 1);
        }
    }

}
