using UnityEngine;

public class Ball : MonoBehaviour
{

    // Configuration parameters
    [SerializeField] Paddle paddle1; // We want to link the paddle with the ball.
    private bool hasStarted = false;

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
        if (hasStarted != true)
        {
            LockBallToPaddle();
            LaunchBallOnMouseClick();
        }
    }

    private void LaunchBallOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 15f);
        }
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y); // Where paddle is!
        transform.position = paddlePos + paddleToBallVector; // Paddle + difference = where ball should be.
    }
}
