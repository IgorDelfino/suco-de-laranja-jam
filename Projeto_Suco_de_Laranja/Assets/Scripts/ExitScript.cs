using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour
{
    public int numItems = 5;
    private PlayerInventory inventory;
    private DialogueTrigger trigger;

    private void Awake()
    {
        inventory = GameObject.Find("Player").GetComponent<PlayerInventory>();
        trigger = gameObject.GetComponent<DialogueTrigger>();
    }

    public void ExitHouse()
    {
        if(inventory.items >= 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//vai pra próxima cena
        }
        else
        {
            trigger.TriggerDialogue();
        }
    }
}
