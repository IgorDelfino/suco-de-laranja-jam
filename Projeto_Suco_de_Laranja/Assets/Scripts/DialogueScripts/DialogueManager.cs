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

    public GameObject player;
    public float typingSpeed;

    public Animator animator;

    private Queue<string> sentences;
    private Queue<Sprite> emotions;
    public bool isDialogueHappening = false;

    public int beep = 1;

    void Start()
    {
        sentences = new Queue<string>();
        emotions = new Queue<Sprite>();
    }

    public void RunDialogue(Dialogue dialogue,ref bool hasFirstDialogue)
    {
        if (!isDialogueHappening)
        {
            instanciateDialogue(dialogue);
        }

        DisplayNextSentence(ref hasFirstDialogue);
        return;
    }

    public void instanciateDialogue(Dialogue dialogue)
    {
        player.GetComponent<playerController>().enabled = false;

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

    public void DisplayNextSentence(ref bool hasFirstDialogue)
    {
        if (sentences.Count == 0)
        {
            EndDialogue();

            hasFirstDialogue = false;
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

            if (beep == 1)
            {
                FindObjectOfType<AudioManager>().Play("PlayerBeep1");
            } else
            {
                FindObjectOfType<AudioManager>().Play("PlayerBeep2");
            }

            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void EndDialogue()
    {
        isDialogueHappening = false;
        animator.SetBool("IsOnDialogue", false);
        player.GetComponent<playerController>().enabled = true;
    }
}
