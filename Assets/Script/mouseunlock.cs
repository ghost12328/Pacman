using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseunlock : MonoBehaviour
{
   void Start()
    {
        // Unlock the cursor and make it visible
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
