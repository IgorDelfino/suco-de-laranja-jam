using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton

    public static Inventory instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("we have more than one inventory (not ideal)");
            return;
        } 

        instance = this;
    }

    #endregion

    public List<Item> items = new List<Item>();

    public void AddItem(Item item)
    {
        items.Add(item);
    }
}
