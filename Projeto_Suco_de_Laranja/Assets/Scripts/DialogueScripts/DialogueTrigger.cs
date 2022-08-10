using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    private bool firstDialogue = false;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().RunDialogue(dialogue,ref firstDialogue);
    }
}
