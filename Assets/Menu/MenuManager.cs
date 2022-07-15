using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PauseGame(){
        Time.timeScale = 0;
    }

    public void ResumeGame(){
        Time.timeScale = 0;
    }

    public void ExitGame(){
        Application.Quit();
        Debug.Log("Quit");
    }

    public void StartGame(){
        SceneManager.LoadScene("Game");
    }
}
