using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFly : MonoBehaviour
{
    // Количество отнимаемых жизней
    private int count = 1;
    // Обработка столкновения с врагом
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Death player = collision.gameObject.GetComponent<Death>();
            player.die(count);
            Destroy(gameObject);
        }
    }
}
