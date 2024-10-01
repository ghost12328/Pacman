using UnityEngine;

public class ShadowCloakPickup : MonoBehaviour
{
    public Inventory inventory; // Reference to the Inventory script

    private void OnTriggerEnter(Collider other) // For 3D triggers, use OnTriggerEnter with Collider
    {
        if (other.CompareTag("Player")) // Ensure the player is tagged as "Player"
        {
            // Call the pickup method from the inventory
            inventory.PickupShadowCloak();
            
            // Destroy the item object after pickup
            Destroy(gameObject);
        }
    }
}
