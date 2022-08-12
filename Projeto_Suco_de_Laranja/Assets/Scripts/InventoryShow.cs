using UnityEngine;

public class InventoryShow : MonoBehaviour
{
    public ToggleOnOff toggle;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            FindObjectOfType<AudioManager>().Play("Interact");
            toggle.Toggle();            
        }
    }
}
