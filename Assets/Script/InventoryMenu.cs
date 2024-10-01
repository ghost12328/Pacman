using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu1 : MonoBehaviour
{
   public GameObject inventoryPanel;  // Assign the inventory panel in the Inspector
    private bool isMenuActive = false; // Track whether the menu is currently active

    void Update()
    {
        // When the player presses the M key, toggle the menu
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMenuActive = !isMenuActive;  // Toggle the active state
            inventoryPanel.SetActive(isMenuActive);
        }
    }

    // Optional: Update button text with item info
    public void UpdateItemButton(Button itemButton, string itemName, int itemCount)
    {
        itemButton.GetComponentInChildren<Text>().text = itemName + ": " + itemCount;
    }
}
