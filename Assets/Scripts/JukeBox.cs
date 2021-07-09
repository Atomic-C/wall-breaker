using UnityEngine;

public class JukeBox : MonoBehaviour
{
    private void Awake()
    {
        int jukeBoxStatus = GameObject.FindObjectsOfType<JukeBox>().Length;

        if (jukeBoxStatus > 1)
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
