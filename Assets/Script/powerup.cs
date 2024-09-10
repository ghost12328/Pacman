using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    // Start is called before the first frame update
    public float freezeDuration = 5f; // Duration the enemy will be frozen

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player collided with the power-up
        if (other.CompareTag("Player"))
        {
            // Freeze all enemies for a set duration
            StartCoroutine(FreezeEnemies());

            // Destroy the power-up after it's collected
            Destroy(gameObject);
        }
    }

    IEnumerator FreezeEnemies()
    {
        // Find all enemies in the scene
        enemychase[] enemies = FindObjectsOfType<enemychase>();

        // Freeze all enemies
        foreach (enemychase enemy in enemies)
        {
            enemy.Freeze(true);
        }

        // Wait for the freeze duration
        yield return new WaitForSeconds(freezeDuration);

        // Unfreeze all enemies after the freeze duration ends
        foreach (enemychase enemy in enemies)
        {
            enemy.Freeze(false);
        }
    }
}
