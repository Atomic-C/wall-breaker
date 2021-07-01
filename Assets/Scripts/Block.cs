﻿using UnityEngine;

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
        if (tag == "Breakable") // We create this if statement so that only Breakable objects are counted.
        {
            level.CountBreakableBlocks();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) // This method calls DestroyBlock method on collision.
    {
        if (tag == "Breakable") // We create this if statement so only Breakable objects are destroyed, by exclusion.
        {
            DestroyBlock();
        }
    }

    private void DestroyBlock()
    {
        PlayBlockSFX();
        Destroy(gameObject);
        level.BlockDestroyed();
        TriggerSparklesVFX();
        // Debug.Log(collision.gameObject.name);
    }

    private void PlayBlockSFX() // This method is responsible for sound effects when called.
    {
        FindObjectOfType<GameStatus>().AddToScore();
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position); // Create an audio source that plays "here"
    }

    private void TriggerSparklesVFX() // This method enables the visual effects upon calling.
    {
        GameObject sparkles = Instantiate(blockSparklesVFX, transform.position, transform.rotation);
        Destroy(sparkles, 1f); // This should stop the VFX clone SPAM.
    }
}
