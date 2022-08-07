using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class importantObject : MonoBehaviour
{
    bool isInObjectTrigger = false;
    public int objectId;

    private void OnTriggerEnter2D(Collider2D other)
    {
        isInObjectTrigger = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        isInObjectTrigger = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) & isInObjectTrigger)
        {
            Debug.Log("estou interagindo com o objeto: " + objectId);
        }
    }
}
