using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//vai pra próxima cena na fila     
    }

    public void QuitGame()
    {
        Debug.Log("Fechando o jogo..");
        Application.Quit();
    }
}
