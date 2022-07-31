using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrorBehavior : MonoBehaviour
{
    public GameObject dialogueStuff;
    public Interacting interactionScript;

    void Update()
    {
        if (interactionScript.Inside)
        {
            dialogueStuff.SetActive(true);
        }

        else
        {
            dialogueStuff.SetActive(false);
        }
    }
}
