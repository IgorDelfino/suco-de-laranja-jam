using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text storyText;
    public Image characterAvatar;

    public Animator animator;

    private Queue<string> sentences;
    private Queue<Sprite> emotions;
    private bool isDialogueHappening = false;

    void Start()
    {
        sentences = new Queue<string>();
        emotions = new Queue<Sprite>();
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
        animator.SetBool("IsOnDialogue", true);

        nameText.text = dialogue.nameOfObject;

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        foreach (Sprite emotion in dialogue.emotions)
        {
            emotions.Enqueue(emotion);
        }
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        characterAvatar.sprite = emotions.Dequeue();
        string sentence = sentences.Dequeue();

        StopAllCoroutines();

        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        storyText.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            storyText.text += letter;
            yield return null;
        }
    }

    public void EndDialogue()
    {
        isDialogueHappening = false;
        animator.SetBool("IsOnDialogue", false);
    }
}
