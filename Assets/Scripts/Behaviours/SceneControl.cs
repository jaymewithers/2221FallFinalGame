using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public string currentScene, mainMenu, gameOver, playScene;

    public void CurrentToMainScene()
    {
        currentScene = mainMenu;
    }

    public void CurrentToGameOverScene()
    {
        currentScene = gameOver;
    }

    public void CurrentToPlayScene()
    {
        currentScene = playScene;
    }
    
    public void LoadScene()
    {
        SceneManager.LoadScene(currentScene);
        Time.timeScale = 1;
    }

    public void PlayAndOffloadAdditiveScene()
    {
        SceneManager.UnloadSceneAsync(currentScene);
        Time.timeScale = 1;
    }

    public void StopAndLoadAdditiveScene()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene(currentScene, LoadSceneMode.Additive);
    }

    public void AdditiveScene()
    {
        SceneManager.LoadScene(currentScene, LoadSceneMode.Additive);
    }
}