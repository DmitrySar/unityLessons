using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Player player;
    void Start()
    {
        //������� ������ �� ������ player
        player = PlayerController.getPlayer();
    }

    // ��������� ������������ � ������
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // ����� ���������� ������
            print(player.dead());
            player.toRedColor();
            //���������� ������ ����� 1 �������
            Invoke("toNormal", 1f);
        }
    }

    void toNormal()
    {
        player.toNormalColor();
    }
}
