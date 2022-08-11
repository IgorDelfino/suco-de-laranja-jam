using UnityEngine;

public class InventoryShow : MonoBehaviour
{
    public ToggleOnOff toggle;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            toggle.Toggle();            
        }
    }
}
