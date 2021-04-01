using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // ќбъ€вим поле static, чтобы обращатьс€ к нему не создава€ объект
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
        else player.move(axisX);

    }

    // создадим метод, возвращающий объект player
    public static Player getPlayer()
    {
        return player;
    }

}
