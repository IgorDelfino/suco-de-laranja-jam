using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool isInRange = false;
    public KeyCode interactKey;
    public UnityEvent interactAction;

    public GameObject key;

    private pauseMenu pauseMenu;

    private void Awake()
    {
        pauseMenu = FindObjectOfType<pauseMenu>();
    }

    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey) && pauseMenu.gameIsPaused == false)
            {
                interactAction.Invoke();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            key.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            key.SetActive(false);
        }
    }

}
