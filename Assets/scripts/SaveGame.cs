using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// создадим пункт меню
[CreateAssetMenu(menuName = "unityLessons/saveGame")]
public class SaveGame : ScriptableObject
{
    public int level;
}
