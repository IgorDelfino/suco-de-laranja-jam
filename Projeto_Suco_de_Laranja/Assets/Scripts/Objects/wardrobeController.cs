using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wardrobeController : MonoBehaviour
{
    public bool isOpen;
    //public Animator animator;

    public Rigidbody2D rb;
    public Vector2 Empurrar;

    public void OpenWardrobe()
    {
        if (isOpen == false)
        {
            //isOpen = true;
            Debug.Log("Empurrando Guarda-roupa..");
            rb.MovePosition(rb.position - Empurrar);
        }
    }
}
