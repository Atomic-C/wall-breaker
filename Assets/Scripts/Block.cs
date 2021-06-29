﻿using UnityEngine;

public class Block : MonoBehaviour
{
    // Configuration parameters
    [SerializeField] AudioClip breakSound;

    // Cached reference
    Level level; //This is where we cache variable of type Level.
    GameStatus gameStatus;

    private void Start()
    {
        level = FindObjectOfType<Level>(); // We're looking for an object of type Level to access it's public methods!!!
        level.CountBreakableBlocks();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();
    }

    private void DestroyBlock()
    {
        FindObjectOfType<GameStatus>().AddToScore();
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position); // Create an audio source that plays "here"
        Destroy(gameObject);
        level.BlockDestroyed(); // Here we countdown the number of blocks on collision.
                                // Debug.Log(collision.gameObject.name);
    }
}
