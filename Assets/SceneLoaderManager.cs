using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoaderManager : MonoBehaviour
{
       //load
    public static void Load(string sceneName)
    {
        SceneLoader.Load(sceneName);
    }

    //progress Load
    public static void ProgressLoad(string SceneName)
    {
       SceneLoader.ProgressLoad(SceneName);
    }

    //Reload Level
    public static void ReloadLevel()
    {
       SceneLoader.ReloadLevel();
    }

    //LoadNextLevel
    public static void LoadNextLevel()
    {
       SceneLoader.LoadNextLevel();
    }

   //Quit Game
    public void QuitGame ()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
