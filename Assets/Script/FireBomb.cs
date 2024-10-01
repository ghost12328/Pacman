using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBomb : Item
{
    public FireBomb(string name, string description, float weight) : base(name, description, weight)
    {
    }

    public override void UseItem()
    {
        // Define what happens when the Fire Bomb is used
        Debug.Log("Fire Bomb used!");
    }
}
