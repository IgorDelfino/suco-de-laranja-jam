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

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("A");
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Player está no trigger1");
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            key.SetActive(true);
            //Debug.Log("Player está no trigger");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log("Player saiu do trigger1");
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            key.SetActive(false);
            //Debug.Log("Player saiu do trigger");
        }
    }

}
