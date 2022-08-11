using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public bool hasKey;
    public bool hasBoxKey;
    public int items=0;

    public void PickUpKey()
    {
        hasKey = true;
    }

    public void AddItem()
    {
        items++;
    }

    public void pickUpBoxKey()
    {
        hasBoxKey = true;
    }
}
