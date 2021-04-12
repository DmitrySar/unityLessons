using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        //перемещаем объект вниз
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        //удаляем объект через ~2 секунды
        Destroy(gameObject, 2f);
    }
}
