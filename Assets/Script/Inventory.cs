using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour, IInventorySubject
{
    private List<Item> items = new List<Item>(); // List to hold items
    private List<IInventoryObserver> observers = new List<IInventoryObserver>(); // Observers list

    public void AddObserver(IInventoryObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IInventoryObserver observer)
    {
        observers.Remove(observer);
    }

    // Notify observers (e.g., update UI)
    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.OnInventoryUpdated(items);
        }
    }

    // Method to retrieve an item by name
    public Item GetItemByName(string itemName)
    {
        return items.Find(item => item.Name == itemName);
    }

    // Method to remove an item from the inventory
    public void RemoveItem(Item item)
    {
        items.Remove(item);
        NotifyObservers(); // Notify observers after removing the item
    }

    // Method to add an item to the inventory
    public void AddItem(Item item)
    {
        items.Add(item);
        Debug.Log($"{item.Name} added to inventory. Total items: {items.Count}");
        NotifyObservers(); // Notify observers after updating inventory
    }

    // Check if the inventory has a specific item by name
    public bool HasItem(string itemName)
    {
        return items.Exists(item => item.Name == itemName);
    }

    // Method to use an item from the inventory
    public void UseItem(string itemName)
    {
        Item item = GetItemByName(itemName);
        if (item != null)
        {
            item.UseItem(); // Call the item's UseItem() method
            RemoveItem(item); // Remove the item after use
            Debug.Log($"{itemName} used.");
            NotifyObservers(); // Notify observers after using the item
        }
        else
        {
            Debug.Log($"No {itemName} found in inventory.");
        }
    }

    // Method to use a health potion from the inventory
    public void UseHealthPotion()
    {
        UseItem("Health Potion");
    }

    // Method to simulate picking up a health potion
    public void PickupHealthPotion()
    {
        HealthPotion healthPotion = new HealthPotion("Health Potion", "Restores health.", 50);
        AddItem(healthPotion); // Add the health potion to the inventory
    }

    // Method to simulate picking up a golden axe
    public void PickupGoldenAxe()
    {
        GoldenAxe goldenAxe = new GoldenAxe("Golden Axe", "A powerful axe for chopping.", 5f);
        AddItem(goldenAxe); // Add the golden axe to the inventory
    }
public void PickupShadowCloak()
{
    ShadowCloak shadowCloak = new ShadowCloak("Shadow Cloak", "Grants stealth.", 1f);
    AddItem(shadowCloak); // Add the shadow cloak to the inventory
}
public void PickupGreenBow()
{
    GreenBow greenBow = new GreenBow("Green Bow", "A powerful green bow.", 3f);
    AddItem(greenBow); // Add the green bow to the inventory
}


}
