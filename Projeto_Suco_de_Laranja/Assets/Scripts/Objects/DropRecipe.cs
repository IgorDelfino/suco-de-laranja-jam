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
            StartCoroutine(AnimationCount());
        }
    }

    public void AddShake()
    {
        shakes++;
    }

    IEnumerator AnimationCount()
    {
        yield return new WaitForSeconds(0.36f);
        FindObjectOfType<AudioManager>().Play("Drop");
        interactable.SetActive(true);
    }

}
