using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorneliusBehavior : MonoBehaviour
{
    public GameObject dialogueStuff;
    public Interacting interactionScript;

    // Update is called once per frame
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
