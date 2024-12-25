using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuickMenu : MonoBehaviour
{
    [SerializeField] private GameObject menuUI; // Assign your menu GameObject in the Inspector
    private bool isMenuActive = false; // Tracks whether the menu is active

    // Update is called once per frame
    void Update()
    {
        // Toggle menu visibility when pressing Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleMenu();
        }
    }

    // Method to toggle the menu
    public void ToggleMenu()
    {
        isMenuActive = !isMenuActive;
        menuUI.SetActive(isMenuActive);

        // Pause or resume the game based on menu state
        Time.timeScale = isMenuActive ? 0 : 1;
    }

    // Method to load a scene by name
    public void LoadScene(string sceneName)
    {
        Time.timeScale = 1; // Ensure the game is unpaused before loading a scene
        SceneManager.LoadScene(sceneName);
    }

    // Method to quit the application
    public void QuitApplication()
    {
        Debug.Log("Quitting the application...");
        Application.Quit();
    }
}
