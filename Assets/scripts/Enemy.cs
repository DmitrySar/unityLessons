using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Player player;
    void Start()
    {
        //Получим ссылку на объект player
        player = PlayerController.getPlayer();
    }

    // Обработка столкновения с врагом
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // вывод количества жизней
            print(player.dead());
            player.toRedColor();
            //отложенный запуск через 1 секунду
            Invoke("toNormal", 1f);
        }
    }

    void toNormal()
    {
        player.toNormalColor();
    }
}
