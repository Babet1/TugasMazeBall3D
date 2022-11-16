using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneLoader
{
    private static string sceneToLoad;

    public static string SceneToLoad { get => sceneToLoad; }


    //load
    public static void Load(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    //progress Load
    public static void ProgressLoad(string SceneName)
    {
        sceneToLoad = SceneName;
        SceneManager.LoadScene("LoadingProgress");
    }

    //Reload Level
    public static void ReloadLevel()
    {
        var currentScene = SceneManager.GetActiveScene().name;
        ProgressLoad(currentScene);
    }

    //LoadNextLevel
    public static void LoadNextLevel()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        int nextLevel = int.Parse(currentSceneName.Split("Level")[1])+ 1;
        string nextSceneName = "Level" + nextLevel;

        if (SceneUtility.GetBuildIndexByScenePath(nextSceneName) == -1)
        {
            Debug.LogError(nextSceneName + "does not exists");
            return;
        }

        ProgressLoad(nextSceneName);
    }
}
