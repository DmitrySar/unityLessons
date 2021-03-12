using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float radius = 0.2f;
    private Rigidbody2D rb;
    private float speed = 8f;
    private float jumpForce = 13f;
    public Transform groundCheck;
    private bool isGround;

    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        flip();
        CheckGround();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
        if (Input.GetAxis("Jump") > 0 && isGround) rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }

    void flip()
    {
        float axisX = Input.GetAxis("Horizontal");
        if (axisX < 0) sprite.flipX = true;
        if (axisX > 0) sprite.flipX = false;
    }

    void CheckGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, radius);
        isGround = colliders.Length > 1;
    }
}
