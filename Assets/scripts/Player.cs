using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //скорость
    private float speed = 5f;
    // сила прыжка
    private float jumpForce = 10f;
    // компонент Rigidbody2D
    private Rigidbody2D rb;
    // компонент SpriteRenderer
    private SpriteRenderer sprite;
    // дочерний компонент checkGround
    private Transform checkGround;
    //радиус для поиска коллайдеров
    private float radius = 0.2f;
    private Animator animator;

    //инициализация объектов
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        checkGround = GameObject.Find("checkGround").transform;
        animator = GetComponent<Animator>();
    }

    // зарпускается при смене кадров
    void Update()
    {
        flip();
        stand();
    }

    // не зависит от частоты кадров
    void FixedUpdate()
    {
        move();
        jump();
    }

    // движение
    void move()
    {
        float axisX = Input.GetAxis("Horizontal");
        if (axisX != 0)
        {
            rb.velocity = new Vector2(axisX * speed, rb.velocity.y);
            animator.SetInteger("state", 2);
        }
    }

    // поворот
    void flip()
    {
        //            опрос нажатия клавиш
        float axisX = Input.GetAxis("Horizontal");
        if (axisX < 0)
        {
            sprite.flipX = true;
        }
        else if (axisX > 0)
        {
            sprite.flipX = false;
        }
    }

    // прыжок
    void jump()
    {
        if (Input.GetAxis("Jump") > 0 && isOnGround())
        {
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
            animator.SetInteger("state", 3);
        }
    }

    // проверка стотит ли объект на платформе
    bool isOnGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(checkGround.position, radius);
        return colliders.Length > 1;
    }

   // в покое
    void stand()
    {
        if (Input.GetAxis("Jump") == 0 && Input.GetAxis("Horizontal") == 0 && isOnGround())
        {
            animator.SetInteger("state", 1);
        }
    }


}
