using UnityEngine;

public class ShadowCloak : Item
{
    public ShadowCloak(string name, string description, float weight) : base(name, description, weight)
    {
    }

    public override void UseItem()
    {
        Debug.Log("Shadow Cloak used.");
        // Add any effects or behavior for when the Shadow Cloak is used.
    }
}
