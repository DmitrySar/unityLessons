using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Объявим поле static, чтобы обращаться к нему не создавая объект
    private static Player player;
    private float axisX;
    private float axisJump;

    // срабатывает до метода start
    void Awake()
    {
        player = new Player(gameObject);
    }

    void Update()
    {      
        if (Input.GetAxis("Jump") == 0 && Input.GetAxis("Horizontal") == 0) player.stand();
        else player.flip(axisX);
    }

    void FixedUpdate()
    {
        axisX = Input.GetAxis("Horizontal");
        axisJump = Input.GetAxis("Jump");
        if (axisJump > 0) player.jump();
        if (axisX != 0) player.move(axisX);

    }

    // создадим метод, возвращающий объект player
    public static Player getPlayer()
    {
        return player;
    }

}
