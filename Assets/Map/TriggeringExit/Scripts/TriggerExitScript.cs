using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TriggerExitScript : MonoBehaviour 
{
        public ExitSignScript exitSign;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Cat")
        {
            exitSign.exitNum += 1;
            Destroy(gameObject);
        }
    }
}
