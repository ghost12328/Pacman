using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : Item
{
    public HealthPotion(string name, string description, float weight) 
        : base(name, description, weight)
    {
    }

    public override void UseItem()
    {
        // Implement the logic for using the potion (e.g., restoring health)
        Debug.Log("Using Health Potion!");
        // You can add logic here to restore health, etc.
    }
}
