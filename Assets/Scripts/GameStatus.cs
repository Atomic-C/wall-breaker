using TMPro;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    // Configuration Parameters
    [Range(0f, 2f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsePerBlockDestroyed = 85;
    [SerializeField] TextMeshProUGUI scoreText;

    // State variables
    [SerializeField] int currentScore = 0;

    private void Start()
    {
        scoreText.text = currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore += pointsePerBlockDestroyed; // currentScore = currentScore + pointsPerBlockDestroyed
        scoreText.text = currentScore.ToString();
    }
}
