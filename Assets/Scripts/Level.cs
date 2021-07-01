using UnityEngine;

public class Level : MonoBehaviour
{
    // Parameters
    [SerializeField] int breakableBlocks; // Serialized for debugging purposes

    // Cached reference
    SceneLoader sceneLoader;

    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>(); // We're looking for an object of type Level to access it's public methods!!!
    }

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed() // Here we countdown the number of blocks on collision.
    {
        breakableBlocks--;
        if (breakableBlocks <= 0) // If we run out of blocks...
        {
            sceneLoader.LoadNextScene(); // We start the next level!!!
        }
    }
}
