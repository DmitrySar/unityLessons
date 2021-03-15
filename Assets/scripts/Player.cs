using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    public Transform groundCheck;
    float speed = 5f;
    float jumpForce = 8f;
    private float radius = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        flip();

    }

    private void FixedUpdate()
    {
        float axisX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(axisX * speed, rb.velocity.y);
        jump();
    }

    void flip()
    {
        float axis = Input.GetAxis("Horizontal");
        if (axis < 0) spriteRenderer.flipX = true;
        if (axis > 0) spriteRenderer.flipX = false; 
    }

    void jump()
    {
        if (Input.GetAxis("Jump") > 0 && chekGround()) rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }

    bool chekGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, radius);
        return colliders.Length > 1;
    }

}
