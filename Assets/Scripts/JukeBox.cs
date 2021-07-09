using UnityEngine;

public class JukeBox : MonoBehaviour
{
    private void Awake() // We apply Singleton design pattern to cache the jukeBoxMusic, so points persist
    { // There can be only one jukeBoxMusic and it must be the same on every scene.
        int jukeBoxMusic = GameObject.FindObjectsOfType<JukeBox>().Length;

        if (jukeBoxMusic > 1)
        {
            gameObject.SetActive(false); // Fixes bug where null reference exceptions happen.
            Destroy(gameObject); // If there is more than one object, destroy yourself
        }
        else
        {
            DontDestroyOnLoad(gameObject); // If there isn't more than one object, don't destroy yourself
        }
    }
}
