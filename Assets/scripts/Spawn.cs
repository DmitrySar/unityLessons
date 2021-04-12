using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject circle;
    float time = 0f;
    void Update()
    {
        //��� �����-�� ����� �� �������� ������ �������
        time -= Time.deltaTime;
        if (time < 0)
        {
            //�������� �������
            Instantiate(circle, transform.position, transform.rotation);
            time = 2f;
        }
    }
}
