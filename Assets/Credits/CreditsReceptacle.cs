using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsReceptacle : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.name == "collider")
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
