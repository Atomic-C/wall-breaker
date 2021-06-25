using UnityEngine;

public class Ball : MonoBehaviour
{

    // Configuration parameters
    [SerializeField] Paddle paddle1; // We want to link the paddle with the ball.
    [SerializeField] float xPush = 2f;
    [SerializeField] float yPush = 15f;
    [SerializeField] AudioClip[] ballSounds;


    // State
    Vector2 paddleToBallVector; // Distance between paddle and the ball
    private bool hasStarted = false;

    // Cached component references
    AudioSource myAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        paddleToBallVector = transform.position - paddle1.transform.position; // Difference between ball and paddle respectively
        myAudioSource = GetComponent<AudioSource>(); // Find component and know it from now on instead of get it all the time.
    }

    // Update is called once per frame
    void Update() // Note this method updates at EVERY FRAME.
    {
        if (!hasStarted) // If hasStarted is false, lock the ball to the paddle and launch on mouse click.
        { //If hasStarted is true the below methods will not be called.
            LockBallToPaddle();
            LaunchBallOnMouseClick();
        }
    }

    private void LaunchBallOnMouseClick() // This method launches the ball on left mouse click.
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true; // As this turns true on click, if statement on update stops.
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
        }
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y); // Where paddle is!
        transform.position = paddlePos + paddleToBallVector; // Paddle + difference = where ball should be.
    }

    private void OnCollisionEnter2D(Collision2D collision) // This method allows sound reproduction on ball collision.
    {
        if (hasStarted == true) // This conditional statement limits sound effects until the game starts.
        {
            AudioClip clip = ballSounds[Random.Range(0, ballSounds.Length)];
            myAudioSource.PlayOneShot(clip);
        }
    }
}
