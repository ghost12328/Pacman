using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInventoryObserver
{
    void OnInventoryUpdated(List<Item> items);
}