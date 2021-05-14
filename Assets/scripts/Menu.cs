using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void loadLevel(int level)
    {  
        SceneManager.LoadScene(level);
    }

    public void exit()
    {
        Application.Quit();
    }    
    
}
