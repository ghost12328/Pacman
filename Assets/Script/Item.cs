using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item
{
  public string Name { get; private set; } // Item name
    public string Description { get; private set; } // Item description
    public float Weight { get; private set; } // Item weight

    public Item(string name, string description, float weight)
    {
        Name = name;
        Description = description;
        Weight = weight;
    }

    // Abstract method to be overridden for item usage
    public abstract void UseItem();
}
