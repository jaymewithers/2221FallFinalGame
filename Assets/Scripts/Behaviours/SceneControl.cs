using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public string sceneName;

    public void LoadNextScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ResumePlay()
    {
        SceneManager.UnloadSceneAsync(sceneName);
        Time.timeScale = 1;
    }

    public void PausePlay()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
    }

    public void AdditiveScene()
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
    }
}