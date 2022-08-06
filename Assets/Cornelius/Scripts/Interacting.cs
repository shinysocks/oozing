using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacting : MonoBehaviour
{
    public bool Inside = false;
    public BallShoot ballShootScript;
    public List<GameObject> screenOoze;
    public AudioManager musicManager;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Cat")
        {
            if (gameObject.name == "TerrorInteraction")
            {
                foreach (GameObject Ooze in screenOoze)
                {
                    Ooze.SetActive(false);
                }

                musicManager.ChangeTrack("DialogueNoise", .2f);
            }
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
