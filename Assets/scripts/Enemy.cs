using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    // Обработка столкновения с врагом
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Death player = collision.gameObject.GetComponent<Death>();
            player.die();
        }
    }
}
