using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Player player;
    private float axisX;
    private float axisJump;

    void Start()
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

}
