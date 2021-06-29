using UnityEngine;

public class GameStatus : MonoBehaviour
{
    // Configuration Parameters
    [Range(0f, 2f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsePerBlockDestroyed = 85;

    // State variables
    [SerializeField] int currentScore = 0;

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore += pointsePerBlockDestroyed; // currentScore = currentScore + pointsPerBlockDestroyed
    }
}
