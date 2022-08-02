using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueBehavior : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public TextMeshProUGUI buttontextDisplay;
    int index = 0;
    public bool isTerror;
    public GameObject normalNextButton;
    public GameObject finalNextButton;
    [TextArea(4, 10)]
    public string[] sentences;

    void Start() 
    {
        Type();
    }

    void Update() 
    {
        if (isTerror && index == sentences.Length - 1)
        {
            normalNextButton.SetActive(false);
            finalNextButton.SetActive(true);
        }
    }

    void Type()
    {
        if (isTerror)
        {
            buttontextDisplay.text = (index +1) + "/14";
        }
        else
        {
            buttontextDisplay.text = (index +1) + "/5";
        }
        textDisplay.text = "";
        textDisplay.text += sentences[index];
    }

    public void NextSentence()
    {
        if (index < sentences.Length - 1)
        {
            if (isTerror)
            {
                buttontextDisplay.text = (index +1) + "/14";
            }
            else
            {
            buttontextDisplay.text = (index +1) + "/5";
            }

            index++;
            Type();
        }

        else
        {
            if (isTerror)
            {
                buttontextDisplay.text = (index +1) + "/14";
            }
            else
            {
                buttontextDisplay.text = (index +1) + "/5";
            }
            index = 0;
            Type();
        }
    }

    public void LastSentence()
    {
        SceneManager.LoadScene("Credits");
    }
}
