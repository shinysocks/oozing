using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacting : MonoBehaviour
{
    public bool Inside = false;
    public BallShoot ballShootScript;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Cat")
        {
            Inside = true;
            ballShootScript.canShoot = false;
        }
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Cat")
        {
            Inside = false;
            ballShootScript.canShoot = true;
        }
    }
}
