using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public Inventory inventory;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inventory.PickupHealthPotion(); // Call the method to add a health potion
            Destroy(gameObject); // Destroy the pickup object
        }
    }
}
