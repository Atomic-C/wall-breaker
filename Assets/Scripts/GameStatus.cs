using TMPro;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    // Configuration Parameters
    [Range(0f, 2f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsePerBlockDestroyed = 85;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] bool isAutoPlayEnabled;

    // State variables
    [SerializeField] int currentScore = 0;

    private void Awake() // We apply Singleton design pattern to cache the GameStatus, so points persist
    {// There can be only one GameStatus and it must be the same.
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;

        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false); // Fixes bug where null reference exceptions happen.
            Destroy(gameObject); // If there is more than one object, destroy yourself
        }
        else
        {
            DontDestroyOnLoad(gameObject); // If there isn't more than one object, don't destroy yourself
        }
    }

    private void Start()
    {
        scoreText.text = currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore() // This method increments score points
    {
        currentScore += pointsePerBlockDestroyed; // currentScore = currentScore + pointsPerBlockDestroyed
        scoreText.text = currentScore.ToString();
    }

    public void ResetGamePoints() // This method is supposed to destroy THIS gameObject. This Class we're in.
    {
        Destroy(gameObject);
    }

    public bool IsAutoPlayEnabled() // This should be true or false wether we select autoplay on serialized variable.
    {
        return isAutoPlayEnabled;
    }
}
