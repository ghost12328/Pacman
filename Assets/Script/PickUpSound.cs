using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSound : MonoBehaviour
{
    public AudioClip pickupSound; // The sound to play on pickup
    private AudioSource audioSource; // Reference to the AudioSource

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
        
        // Check if the AudioSource component is missing
        if (audioSource == null)
        {
            Debug.LogError("AudioSource component is missing on " + gameObject.name);
        }
        
        // Check if the AudioClip is assigned
        if (pickupSound == null)
        {
            Debug.LogError("Pickup sound is not assigned on " + gameObject.name);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Make sure this tag matches your player's tag
        {
            // Play the pickup sound
            if (audioSource != null && pickupSound != null)
            {
                audioSource.PlayOneShot(pickupSound);
            }

            // Optional: You can also call a method to add the item to the inventory here
            // Example: Inventory.Instance.AddItem(new YourItem(...));

            Destroy(gameObject); // Destroy the pickup object after collecting it
        }
    }
}
