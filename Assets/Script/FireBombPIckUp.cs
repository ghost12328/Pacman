using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBombPickUp : MonoBehaviour
{
    public Inventory inventory; // Reference to the inventory

    private void OnTriggerEnter(Collider other) // For 3D, replace with OnTriggerEnter2D for 2D
    {
        if (other.CompareTag("Player")) // Assuming your player has the tag "Player"
        {
            FireBomb fireBomb = new FireBomb("Fire Bomb", "A powerful bomb with fire damage.", 1.5f);
            inventory.AddItem(fireBomb); // Add Fire Bomb to inventory
            Debug.Log("Picked up Fire Bomb!");
            Destroy(gameObject); // Remove Fire Bomb from the scene
        }
    }
}
