using UnityEngine;
using UnityEngine.UI;

public class GreenBowButton : MonoBehaviour
{
    public Button greenBowButton;
    private Inventory inventory;

    private void Start()
    {
        greenBowButton.onClick.AddListener(OnGreenBowButtonClicked);
        inventory = FindObjectOfType<Inventory>();
    }

    private void OnGreenBowButtonClicked()
    {
        Item greenBow = inventory.GetItemByName("Green Bow");
        if (greenBow != null)
        {
            greenBow.UseItem(); // Use the Green Bow
        }
    }
}
