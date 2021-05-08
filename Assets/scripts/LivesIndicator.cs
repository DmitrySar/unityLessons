using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesIndicator : MonoBehaviour
{
    // массив картинок с сердечками
    [SerializeField] private Image[] images;
    // картинка с красным сердечком
    [SerializeField] private Sprite lifeOn;
    // картинка с серым сердечком
    [SerializeField] private Sprite lifeOff;
    // поле с игровым персонажем
    [SerializeField] private GameObject death;
    // компонент Death персонажа
    private Death player;

    // Получим компонент Death у игрока
    void Start()
    {
        player = death.GetComponent<Death>();
    }

    // заполняем массив сердечками в зависимости от количества жизней
    void Update()
    {
        for (int i = 0; i < images.Length; i ++)
        {
            if (player.getLivesCount() < i)
            {
                images[i].sprite = lifeOff;
            }
            else
            {
                images[i].sprite = lifeOn;
            }
        }
    }
}
