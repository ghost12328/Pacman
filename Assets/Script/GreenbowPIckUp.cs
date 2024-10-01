using UnityEngine;

public class GreenBowPickup : MonoBehaviour
{
    private Inventory inventory;

    private void Start()
    {
        inventory = FindObjectOfType<Inventory>(); // Find the player's inventory
    }

    private void OnTriggerEnter(Collider other) // Use OnTriggerEnter for 3D
    {
        if (other.CompareTag("Player")) // Make sure the player has the "Player" tag
        {
            inventory.PickupGreenBow();
            Destroy(gameObject); // Destroy the Green Bow object after picking it up
        }
    }
}
