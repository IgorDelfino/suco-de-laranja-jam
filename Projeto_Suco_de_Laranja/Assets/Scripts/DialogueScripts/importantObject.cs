using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class importantObject : MonoBehaviour
{
    public bool isInObjectTrigger = false;
    public Dialogue dialogue;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isInObjectTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isInObjectTrigger = false;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) & isInObjectTrigger)
        {
            FindObjectOfType<DialogueManager>().RunDialogue(dialogue);
        }
    }
}
