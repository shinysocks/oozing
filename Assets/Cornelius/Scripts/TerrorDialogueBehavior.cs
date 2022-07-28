using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TerrorDialogueBehavior : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    [TextArea(4, 10)]
    public string[] sentences;
    int index = 0;
    public bool Completed = false;
    public CatBehavior catScript;
    public GameObject normalNextButton;
    public GameObject finalNextButton;


    void Start() 
    {
        Type();
    }
    
    void Update()
    {
        if (index == sentences.Length - 1)
        {
            catScript.walkSpeed = 0f;
            normalNextButton.SetActive(false);
            finalNextButton.SetActive(true);
        }
    }

    void Type()
    {
        textDisplay.text = "";
        textDisplay.text += sentences[index];
    }

    public void LastSentence()
    {
        SceneManager.LoadScene("Menu"); //credits scene
    }

}
