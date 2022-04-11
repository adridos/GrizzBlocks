using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //need to use this when changing scenes.

public class MainMenu : MonoBehaviour
{

    //function that is called whenever we press the play button
    public void PlayGame () {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("Tetris");
    }

    public void QuitGame () {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void QueueCredits () {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        SceneManager.LoadScene("credits");
    }

    public void Menu()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Title Screen");
    }
}
