using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ExploreClicked : MonoBehaviour
{
    public void LoadScene(string MainScene)
    {
        SceneManager.LoadScene(MainScene);
    }

        // Method to quit the application
    public void QuitApplication()
    {
        Debug.Log("Quitting the application...");
        Application.Quit();
    }
}
