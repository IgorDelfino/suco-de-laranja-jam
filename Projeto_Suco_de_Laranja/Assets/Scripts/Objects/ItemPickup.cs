using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public string[] itemsThatIHave;

    public Item item;

    public void pickUp()
    {
        Debug.Log("estou tentando pegar o item" + item.name);

        Inventory.instance.AddItem(item);

        Destroy(gameObject);
    } 
}
