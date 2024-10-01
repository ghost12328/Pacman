using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseGoldenAxeButton : MonoBehaviour
{
    public Inventory inventory; // Reference to the player's inventory
    public Button useGoldenAxeButton; // Reference to the button

    private void Start()
    {
        // Add a listener to the button to call UseGoldenAxe when clicked
        useGoldenAxeButton.onClick.AddListener(UseGoldenAxe);
    }

    private void UseGoldenAxe()
    {
        // Check if the inventory contains a golden axe
        Item goldenAxe = inventory.GetItemByName("Golden Axe"); // Get the item from inventory

        if (goldenAxe != null)
        {
            goldenAxe.UseItem(); // Use the item
            inventory.RemoveItem(goldenAxe); // Remove it after use
            Debug.Log("Used Golden Axe!");
        }
        else
        {
            Debug.Log("No Golden Axe available!");
        }
    }
}
