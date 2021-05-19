using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelLoader : MonoBehaviour
{
    [SerializeField] private SaveGame save;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // устанавливаем уровень в 2
            save.level = 2;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }    
    }
}
