using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void ToTitleFromEnd()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }

}
