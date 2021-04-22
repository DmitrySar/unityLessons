using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    //обрабатываем взаимодействие с игроком
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Death player = collision.gameObject.GetComponent<Death>();
            player.addLivesCount();
            Destroy(gameObject);
        }
    }
}
