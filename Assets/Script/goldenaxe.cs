using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenAxe : Item
{
    public GoldenAxe(string name, string description, float weight) 
        : base(name, description, weight)
    {
    }

    public override void UseItem()
    {
        // Add logic for using the axe (e.g., equip, attack)
        Debug.Log($"Using {Name}: {Description}");
    }
}
