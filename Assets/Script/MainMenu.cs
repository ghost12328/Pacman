using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject inventoryPanel;  // Assign the inventory panel in the Inspector
    private bool isMenuActive = false;  // Track whether the menu is currently active

    void Update()
    {
        // When the player presses the M key, toggle the menu
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMenuActive = !isMenuActive;  // Toggle the active state
            inventoryPanel.SetActive(isMenuActive);

            // Lock or unlock the cursor based on the menu state
            if (isMenuActive)
            {
                UnlockCursor();
            }
            else
            {
                LockCursor();
            }
        }
    }

    // Method to lock the cursor
    private void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false; // Hide the cursor
    }

    // Method to unlock the cursor
    private void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true; // Show the cursor
    }

    // Optional: Update button text with item info
    public void UpdateItemButton(Button itemButton, string itemName, int itemCount)
    {
        itemButton.GetComponentInChildren<Text>().text = itemName + ": " + itemCount;
    }

}
