using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    GameStatus gameStatus;

    public void LoadNextScene() // Thus method loads the next scene by incrementing + 1 to the current scene index.
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene() // This method loads the first scene, as per the build settings.
    {
        FindObjectOfType<GameStatus>().ResetGamePoints(); // Apparently we can't instantiate with new keyword!??
        SceneManager.LoadScene(0);
        //GameStatus gameStatus = new GameStatus();
        //gameStatus.ResetGamePoints(); // This calls the method responsible for resetting the game points before starting the 
    }

    public void EndScenes() // This method calls the Applicaion Quit() method that quits the game. 
    {
        Application.Quit();
    }
}

// Application.Quit() documentation: https://docs.unity3d.com/ScriptReference/Application.Quit.html
