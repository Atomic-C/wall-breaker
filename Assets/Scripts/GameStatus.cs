using UnityEngine;

public class GameStatus : MonoBehaviour
{
    // Parameters
    [Range(0f, 2f)] [SerializeField] float gameSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }
}
