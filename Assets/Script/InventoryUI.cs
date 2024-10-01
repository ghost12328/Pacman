using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour, IInventoryObserver
{
    public Inventory inventory;  // Reference to the Inventory
    public Text healthPotionCountText;  // Text to display the health potion count

    private void Start()
    {
        // Add this UI as an observer of the inventory
        inventory.AddObserver(this);
    }

    public void OnInventoryUpdated(List<Item> items)
    {
        int healthPotionCount = 0;

        // Count the number of health potions in the inventory
        foreach (Item item in items)
        {
            if (item.Name == "Health Potion")
            {
                healthPotionCount++;
            }
        }

        // Update the UI text
        healthPotionCountText.text = $"Health Potions: {healthPotionCount}";
    }
}
