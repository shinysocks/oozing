using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueBehavior : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    [TextArea(4, 10)]
    public string[] sentences;
    int index = 0;

    void Start() 
    {
        Type();
    }

    void Type()
    {

        textDisplay.text = "";
        textDisplay.text += sentences[index];
    }

    public void NextSentence()
    {
        if (index < sentences.Length - 1)
        {
            index++;
            Type();
        }

        else
        {
            index = 0;
            Type();
        }
    }
}
