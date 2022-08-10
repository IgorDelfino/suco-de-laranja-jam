using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public bool hasKey;
    public int items=0;

    public void PickUpKey()
    {
        hasKey = true;
    }

    public void AddItem()
    {
        items++;
    }
}
