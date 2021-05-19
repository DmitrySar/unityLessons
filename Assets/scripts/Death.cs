using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    // количество жизней
    [SerializeField] private int livesCount;
    //максимальное количество жизней
    private int maxLivesCount;
    Rigidbody2D rb;
    SpriteRenderer sprite;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        maxLivesCount = livesCount;
    }

    //умереть
    public int die(int count)
    {
        livesCount -= count;
        // если количество жизней меньше 0 загружаем сцену заново
        if (livesCount < -1) SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        rb.AddForce(transform.up * PlayerConfig.jumpForce / 2, ForceMode2D.Impulse);
        toRedColor();
        //отложенный запуск через 1 секунду
        Invoke("toNormalColor", 0.3f);
        return livesCount;

    }


    // окрашивание игрока в красный цвет
    public void toRedColor()
    {
        sprite.color = new Color(1f, 1f - sprite.color.g, 1f - sprite.color.b);
    }

    // возвращаем прежний цвет
    public void toNormalColor()
    {
        sprite.color = new Color(1f, 1f, 1f);
    }

    //возврат количества жизней
    public int getLivesCount()
    {
        return livesCount;
    }

    // вывод на экран количества жизней
    private void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 100, 30), "lifes: " + livesCount);
    }

    //добавляем количество жизней
    public void addLivesCount()
    {
        if (livesCount < maxLivesCount)
        {
            livesCount++;
        }
    }

}
