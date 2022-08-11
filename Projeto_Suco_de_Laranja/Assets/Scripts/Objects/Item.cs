using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new important item", menuName = "Inventory/Important")]
public class Item : ScriptableObject
{
    public string Name;

    public Dialogue dialogue;

    public Sprite objectSprite;
}
