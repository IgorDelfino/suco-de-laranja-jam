using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wardrobeController : MonoBehaviour
{
    public bool isOpen;
    //public Animator animator;

    public void OpenWardrobe()
    {
        if (isOpen == false)
        {
            isOpen = true;
            Debug.Log("Abrindo Guarda-roupa..");
        }
    }
}
