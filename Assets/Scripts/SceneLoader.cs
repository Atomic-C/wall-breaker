using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void EndScenes() // This method calls the Applicaion Quit() method that quits the game. 
    {
        Application.Quit();
    }
}

// Application.Quit() documentation: https://docs.unity3d.com/ScriptReference/Application.Quit.html
