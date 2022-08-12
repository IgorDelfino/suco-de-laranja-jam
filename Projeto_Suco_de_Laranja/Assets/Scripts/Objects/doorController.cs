using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorController : MonoBehaviour
{
    public GameObject player;
    public Vector2 position;

    public Dialogue dialogue;
    private bool firstDialogue = false;

    //Porta Trancada
    public void UnlockDoor()
    {
        PlayerInventory inventory = player.GetComponent<PlayerInventory>();

        if (inventory.hasKey == true)
        {
            EnterRoom();
        } else
        {
            FindObjectOfType<DialogueManager>().RunDialogue(dialogue, ref firstDialogue);
        }
    }

    //Porta Destrancada
    public void EnterRoom()
    {
        player.transform.position = new Vector2(position.x,position.y);
        FindObjectOfType<AudioManager>().Play("Door");
    }
}
