using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    // Подключаем кнопку
    [SerializeField] private Button level2;
    // Подключаем SaveGame
    [SerializeField] private SaveGame save;

    private void Update()
    {
        // делаем кнопку активной, если пройден 1-й уровень
        if (save.level > 1)
        {
            level2.interactable = true;
        }
    }
    public void loadLevel(int level)
    {  
        SceneManager.LoadScene(level);
    }

    public void exit()
    {
        Application.Quit();
    }    
    
}
