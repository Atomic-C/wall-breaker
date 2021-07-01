using UnityEngine;

public class Block : MonoBehaviour
{
    // Configuration parameters
    [SerializeField] AudioClip breakSound;
    [SerializeField] GameObject blockSparklesVFX;

    // Cached reference
    Level level; //This is where we cache variable of type Level.
    GameStatus gameStatus;

    private void Start()
    {
        level = FindObjectOfType<Level>(); // We're looking for an object of type Level to access it's public methods!!!
        level.CountBreakableBlocks();
    }

    private void OnCollisionEnter2D(Collision2D collision) // This method calls DestroyBlock method on collision.
    {
        DestroyBlock();
    }

    private void DestroyBlock()
    {
        FindObjectOfType<GameStatus>().AddToScore();
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position); // Create an audio source that plays "here"
        Destroy(gameObject);
        level.BlockDestroyed(); // Here we countdown the number of blocks on collision.
        TriggerSparklesVFX();
        // Debug.Log(collision.gameObject.name);
    }

    private void TriggerSparklesVFX() // This method enables the visual effects upon calling.
    {
        GameObject sparkles = Instantiate(blockSparklesVFX, transform.position, transform.rotation);
    }
}
