using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInventorySubject
{
    void AddObserver(IInventoryObserver observer);
    void RemoveObserver(IInventoryObserver observer);
    void NotifyObservers();
}
