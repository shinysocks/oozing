using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowCubeScript : MonoBehaviour
{
    public CatBehavior catScript;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Cat")
        {
            catScript.walkSpeed -= 2f;
            catScript.frameRate -= 3f;
            Destroy(gameObject);
        }
        
    }
}
