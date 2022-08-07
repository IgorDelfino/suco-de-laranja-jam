using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    private bool isDialogueHappening = false;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void RunDialogue(Dialogue dialogue)
    {
        if (!isDialogueHappening)
        {
            instanciateDialogue(dialogue);
        }

        DisplayNextSentence();
        return;
    }

    public void instanciateDialogue(Dialogue dialogue)
    {
        Debug.Log("Instanciating story about: " + dialogue.nameOfObject);

        sentences.Clear();

        isDialogueHappening = true;

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
    }

    public void EndDialogue()
    {
        isDialogueHappening = false;
        Debug.Log("End of story");
    }
}
