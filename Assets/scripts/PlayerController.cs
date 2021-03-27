using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Player player;
    private float axisX;
    private float axisJump;

    //инициализация объектов
    void Start()
    {
        player = new Player(gameObject);
    }

    // зарпускается при смене кадров
    void Update()
    {      
        if (Input.GetAxis("Jump") == 0 && Input.GetAxis("Horizontal") == 0) player.stand();
        else player.flip(axisX);
    }

    // не зависит от частоты кадров
    void FixedUpdate()
    {
        axisX = Input.GetAxis("Horizontal");
        axisJump = Input.GetAxis("Jump");
        if (axisJump > 0) player.jump();
        else player.move(axisX);

    }

}
