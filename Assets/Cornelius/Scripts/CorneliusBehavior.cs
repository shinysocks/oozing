using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorneliusBehavior : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public GameObject dialogueStuff;
    public Interacting interactionScript;
    public List<Sprite> idleAnimation;
    public float frameRate;

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

        Animate();
    }

    void Animate()
    {
        int totalFrames = (int)(Time.time * frameRate);
        int frame = totalFrames % idleAnimation.Count; 

        spriteRenderer.sprite = idleAnimation[frame];
    }
}
