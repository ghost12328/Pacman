using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  

public class collect : MonoBehaviour
{
   public int scoreValue = 1;  // The amount of score this collectible gives

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player collided with the collectible
        if (other.CompareTag("Player"))
        {
            // Add score to the game using GameManager
            GameManager.instance.AddScore(scoreValue);

            // Destroy the collectible after it's collected
            Destroy(gameObject);
        }
    }
}
