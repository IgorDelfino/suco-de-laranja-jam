using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OpenBox : MonoBehaviour
{
    
    public Dialogue dialogue;
    private bool firstDialogue;
    public UnityEvent OpenAction; 


    public void UnlockBox()
    {
        PlayerInventory inventory = FindObjectOfType<PlayerInventory>();

        if (inventory.hasBoxKey == true)
        {
            OpenAction.Invoke();
        }
        else
        {
            FindObjectOfType<DialogueManager>().RunDialogue(dialogue, ref firstDialogue);
        }
    }
}
