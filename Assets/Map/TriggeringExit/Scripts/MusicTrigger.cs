using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    public AudioManager musicManager;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Cat")
        {
            musicManager.ChangeTrack("WalkUp", .6f);
            Destroy(gameObject);
        }
    }
}
