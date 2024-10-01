using UnityEngine;
using UnityEngine.UI;

public class ShadowcloakButton : MonoBehaviour
{
    public Inventory inventory; // Reference to the Inventory
    public Button shadowCloakButton; // Reference to the Shadow Cloak button

    private void Start()
    {
        // Ensure the button is initially inactive
        shadowCloakButton.gameObject.SetActive(false);
    }

    private void Update()
    {
        // Check if the inventory has the Shadow Cloak and update button visibility
        if (inventory != null)
        {
            bool hasShadowCloak = inventory.GetItemByName("Shadow Cloak") != null;
            shadowCloakButton.gameObject.SetActive(hasShadowCloak);
        }
    }

    public void UseShadowCloak()
    {
        // Check if the inventory has the Shadow Cloak and use it
        if (inventory != null && inventory.GetItemByName("Shadow Cloak") != null)
        {
            inventory.UseItem("Shadow Cloak");
            Debug.Log("Used Shadow Cloak.");
        }
    }
}
