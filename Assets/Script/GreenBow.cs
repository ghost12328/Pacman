using UnityEngine;

public class GreenBow : Item
{
    public GreenBow(string name, string description, float weight) : base(name, description, weight)
    {
    }

    public override void UseItem()
    {
        // Define what happens when the player uses the Green Bow
        Debug.Log("Green Bow used!");
    }
}
