using UnityEngine;

public class Ball : MonoBehaviour
{

    // Configuration parameters
    [SerializeField] Paddle paddle1; // We want to link the paddle with the ball.

    // State
    Vector2 paddleToBallVector; // Distance between paddle and the ball

    // Start is called before the first frame update
    void Start()
    {
        paddleToBallVector = transform.position - paddle1.transform.position; // Difference between ball and paddle respectively
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y); // Where paddle is!
        transform.position = paddlePos + paddleToBallVector; // Paddle + difference = where ball should be.
    }
}
