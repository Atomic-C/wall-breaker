using UnityEngine;

public class Block : MonoBehaviour
{
    // Configuration parameters
    [SerializeField] AudioClip breakSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position); // Create an audio source that plays "here"
        Destroy(gameObject);
        // Debug.Log(collision.gameObject.name);
    }
}
