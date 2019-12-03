using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //start button
    public void StartGame()
    {
        Debug.Log("Loading game...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //exit button
    public void ExitGame()
    {
        Debug.Log("Leaving game session...thank you for playing!");
        Application.Quit();
    }
}
