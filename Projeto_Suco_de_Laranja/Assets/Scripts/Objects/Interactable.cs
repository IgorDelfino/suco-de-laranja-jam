using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool isInRange = false;
    public KeyCode interactKey;
    public UnityEvent interactAction;

    public bool hasFirstDialogue;
    public Dialogue firstDialogue;

    public GameObject key;

    private pauseMenu pauseMenu;
    private playerController playerController;

    private void Awake()
    {
        pauseMenu = FindObjectOfType<pauseMenu>();
        playerController = FindObjectOfType<playerController>();
    }

    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey) && pauseMenu.gameIsPaused == false && playerController.triggers <= 1)
            {
                /*if (hasFirstDialogue==true)
                {
                    FindObjectOfType<DialogueManager>().RunDialogue(firstDialogue,ref hasFirstDialogue);
                } else
                {
                    interactAction.Invoke();
                }*/
                Interact();
                    
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            key.SetActive(true);
            playerController.triggers++;
        }
    }

    public void Interact()
    {
        if (hasFirstDialogue == true)
        {
            FindObjectOfType<DialogueManager>().RunDialogue(firstDialogue, ref hasFirstDialogue);
        }
        else
        {
            interactAction.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            key.SetActive(false);
            playerController.triggers--;
        }
    }

}
