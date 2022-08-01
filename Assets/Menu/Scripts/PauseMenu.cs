using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public BallShoot ballShootScript;
    public GameObject interactionField;
    public GameObject terrorInteractionField;
    

    public static bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isPaused)
            {
                terrorInteractionField.SetActive(true);
                interactionField.SetActive(true);
                ResumeGame();
            }

            else
            {
                terrorInteractionField.SetActive(false);
                interactionField.SetActive(false);
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        ballShootScript.canShoot = false;
        isPaused = true;
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(true);
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1;
        pauseMenuUI.SetActive(false);
        ballShootScript.canShoot = true;
        interactionField.SetActive(true);
        terrorInteractionField.SetActive(true);
    }


    public void ToTitle()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
        isPaused = false;
    }
}
