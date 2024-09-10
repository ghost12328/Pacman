using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
  // This method will be linked to the Button's OnClick event
    public void StartGame()
    {
        // Load the game scene (replace "GameScene" with the name of your actual game scene)
        SceneManager.LoadScene("game");
    }

}
