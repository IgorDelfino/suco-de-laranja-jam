using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongManager : MonoBehaviour
{
    PlayerInventory inventory;

    public AudioSource[] tracks;

    private void Awake()
    {
        inventory = FindObjectOfType<PlayerInventory>();

    }

    public void UnMute()
    {
        /*  if (inventory.items == 1)
          {
              tracks[0].mute = false;


          } else if (inventory.items == 2)
          {
              tracks[1].mute = false;
              tracks[2].mute = false;

          } else if (inventory.items == 3)
          {
              tracks[3].mute = false;
          }
          else if (inventory.items == 4)
          {
              tracks[4].mute = false;
              tracks[5].mute = false;
          }
          */

        switch (inventory.items)
        {
            case 1:
                tracks[0].mute = false;
                break;

            case 2:
                tracks[1].mute = false;
                tracks[2].mute = false;
                break;

            case 3:
                tracks[3].mute = false;
                break;

            case 4:
                tracks[4].mute = false;
                tracks[5].mute = false;
                break;

            default:
                break;
        }
    }
}
