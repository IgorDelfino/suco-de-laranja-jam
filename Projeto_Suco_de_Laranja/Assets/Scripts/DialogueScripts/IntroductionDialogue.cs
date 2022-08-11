using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroductionDialogue : MonoBehaviour
{
    public int seconds = 4;
    public Animator anim;

    public void NextScene()
    {
        anim.SetTrigger("Fade");
        StartCoroutine(CountSeconds());
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator CountSeconds()
    {
        yield return new WaitForSeconds(seconds);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
