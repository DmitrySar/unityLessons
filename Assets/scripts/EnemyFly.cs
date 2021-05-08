using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFly : MonoBehaviour
{
    // ���������� ���������� ������
    private int count = 1;
    // ��������� ������������ � ������
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
