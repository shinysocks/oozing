using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject pauseMenuUI; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }

            else
            {
                PauseGame();
            }
        }
    }
    public static bool isPaused = false;

    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(true);
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1;
        pauseMenuUI.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void ToTitle()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
        isPaused = false;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }
}
