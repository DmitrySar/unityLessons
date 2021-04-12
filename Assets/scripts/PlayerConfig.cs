using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConfig
{
    //скорость
    public const float speed = 5f;
    // сила прыжка
    public const float jumpForce = 10f;
    //радиус для поиска коллайдеров
    public const float radius = 0.2f;
    //индексы для анимации
    public const int STAND_INDEX = 1;
    public const int MOVE_INDEX = 2;
    public const int JUMP_INDEX = 3;
}
