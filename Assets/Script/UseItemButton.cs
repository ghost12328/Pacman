using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseItemButton : MonoBehaviour
{
    public Inventory inventory; // Reference to the player's inventory
    public Button useHealthPotionButton; // Reference to the button

    private void Start()
    {
        // Add a listener to the button to call UseHealthPotion when clicked
        useHealthPotionButton.onClick.AddListener(UseHealthPotion);
    }

    private void UseHealthPotion()
    {
        // Find the health potion in the inventory
        Item potion = inventory.GetItemByName("Health Potion");
        if (potion != null)
        {
            // Use the health potion
            potion.UseItem();
            // Remove it from the inventory
            inventory.RemoveItem(potion);
            Debug.Log("Used Health Potion!");
        }
        else
        {
            Debug.Log("No Health Potion available!");
        }
    }
}
