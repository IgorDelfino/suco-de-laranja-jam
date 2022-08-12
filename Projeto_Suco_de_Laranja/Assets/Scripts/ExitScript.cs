using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class ExitScript : MonoBehaviour
{
    public int numItems = 5;
    private PlayerInventory inventory;
    private DialogueTrigger trigger;
    public UnityEvent exitEvent;

    public Animator anim;
    public int countdown=2;

    private void Awake()
    {
        inventory = GameObject.Find("Player").GetComponent<PlayerInventory>();
        trigger = gameObject.GetComponent<DialogueTrigger>();
    }

    public void ExitHouse()
    {
        if(inventory.items >= 5)
        {
            exitEvent.Invoke();
        }
        else
        {
            trigger.TriggerDialogue();
        }
    }

    public void EndGame()
    {
        anim.SetTrigger("Fade");
        StartCoroutine(CountSeconds());
    }

    IEnumerator CountSeconds()
    {
        yield return new WaitForSeconds(countdown);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
