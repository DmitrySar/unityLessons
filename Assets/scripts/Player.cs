using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    // компонент Rigidbody2D
    private Rigidbody2D rb;
    // компонент SpriteRenderer
    private SpriteRenderer sprite;
    // дочерний компонент checkGround
    private Transform checkGround;
    private Animator animator;
    private GameObject player;
    private int currentAnimationIndex = PlayerConfig.STAND_INDEX;

    
    //конструктор
    public Player(GameObject player)
    {
        this.player = player;
        rb = player.GetComponent<Rigidbody2D>();
        sprite = player.GetComponent<SpriteRenderer>();
        checkGround = player.transform.Find("checkGround").transform;
        animator = player.GetComponent<Animator>();

    }

    // движение
    public void move(float axisX)
    {
        
        if (axisX != 0)
        {
            rb.velocity = new Vector2(axisX * PlayerConfig.speed, rb.velocity.y);
            animator.SetInteger("state", PlayerConfig.MOVE_INDEX);
        }
    }

    // поворот
    public void flip(float axisX)
    {
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
    public void jump()
    {
        if (isOnGround())
        {
            // устанавливаем скорость в ноль
            rb.velocity = Vector2.zero;
            rb.AddForce(player.transform.up * PlayerConfig.jumpForce, ForceMode2D.Impulse);
            animator.SetInteger("state", PlayerConfig.JUMP_INDEX);
        }
    }

    // проверка стотит ли объект на платформе
    bool isOnGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(checkGround.position, PlayerConfig.radius);
        return colliders.Length > 1;
    }

   // в покое
    public void stand()
    {
        if (isOnGround())
        {
            animator.SetInteger("state", currentAnimationIndex);
        }
    }

    public void setCurrentAnimationIndex(int index)
    {
        currentAnimationIndex = index;
    }

}
