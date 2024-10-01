using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryHolder : MonoBehaviour
{
    public Inventory playerInventory;

    private void Awake()
    {
        playerInventory = new Inventory();  // Ensure the inventory is initialized
    }

}
