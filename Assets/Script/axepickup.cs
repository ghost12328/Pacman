using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenAxePickUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the player is the one entering the trigger
        if (other.CompareTag("Player"))
        {
            // Assuming the player has a reference to the Inventory script
            Inventory playerInventory = other.GetComponent<Inventory>();

            if (playerInventory != null)
            {
                // Create a new Golden Axe item and add it to the inventory
                GoldenAxe goldenAxe = new GoldenAxe("Golden Axe", "A mighty axe with golden shine.", 10);
                playerInventory.AddItem(goldenAxe);

                // Destroy the Golden Axe object after pickup
                Destroy(gameObject);
            }
        }
    }
}
