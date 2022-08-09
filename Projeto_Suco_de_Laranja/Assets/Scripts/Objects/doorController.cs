using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorController : MonoBehaviour
{
    public GameObject player;
    public Vector2 position;

    public void EnterRoom()
    {
        player.transform.position = new Vector2(position.x,position.y);
    }
}
