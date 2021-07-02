using UnityEngine;

public class Level : MonoBehaviour
{
    // Parameters
    [SerializeField] int blocks; // Serialized for debugging purposes

    // Cached reference
    SceneLoader sceneLoader;

    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>(); // We're looking for an object of type Level to access it's public methods!!!
    }

    public void CountBlocks() // This method counts Blocks.
    {
        blocks++; // Times change, and so do blocks. Since we have many types of them, we now count them all.
    }

    public void BlockDestroyed() // Here we countdown the number of blocks on collision.
    {
        blocks--;
        if (blocks <= 0) // If we run out of blocks...
        {
            sceneLoader.LoadNextScene(); // We start the next level!!!
        }
    }
}
