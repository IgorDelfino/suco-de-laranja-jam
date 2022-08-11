using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropRecipe : MonoBehaviour
{
    private int shakes;

    public GameObject interactable;
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        if (shakes >= 2)
        {
            anim.SetTrigger("Drop");
            interactable.SetActive(true);
        }
    }

    public void AddShake()
    {
        shakes++;
    }
}
