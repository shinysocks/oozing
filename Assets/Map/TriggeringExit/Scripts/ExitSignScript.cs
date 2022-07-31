using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitSignScript : MonoBehaviour
{
    public int exitNum;
    public GameObject exitSign;
    public GameObject cornelius;
    void Update()
    {
        if (exitNum == 4)
        {
            exitSign.SetActive(true);
            cornelius.SetActive(false);
        }
    }
}
