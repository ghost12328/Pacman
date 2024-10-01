using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireBombButton : MonoBehaviour
{
    public Inventory inventory; // Reference to the player's inventory
    public Button fireBombButton; // Reference to the button

    private void Start()
    {
        // Add a listener to the button to call UseFireBomb when clicked
        fireBombButton.onClick.AddListener(UseFireBomb);
    }

    private void UseFireBomb()
    {
        // Check if the inventory has a Fire Bomb and use it
        if (inventory.HasItem("Fire Bomb"))
        {
            inventory.UseItem("Fire Bomb");  // Use the Fire Bomb
            Debug.Log("Used Fire Bomb!");
        }
        else
        {
            Debug.Log("No Fire Bomb available!");
        }
    }
}
