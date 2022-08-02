using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public CatBehavior playerScript;
    private Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;

    int enemyHealth = 0;

    // Animation
    public List<Sprite> walkingAnimation;
    public Sprite deathAnimation;
    public float frameRate;
    bool alive = true;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        enemyHealth = Random.Range(2, 4);
    }

    void FixedUpdate() 
    {
        if (alive)
        {
        Animate();
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Cannonball")
        {
            enemyHealth -= 1;
            if (enemyHealth <= 0)

            {
                alive = false;
                spriteRenderer.sprite = deathAnimation;
                Destroy(gameObject, .1f);
            }
        }

        if (other.gameObject.tag == "Cat")
        {
            alive = false;
            spriteRenderer.sprite = deathAnimation;
            Destroy(gameObject);
            playerScript.Gunkiness += 1;
        }
    }

    void Animate()
    {
        int totalFrames = (int)(Time.time * frameRate);
        int frame = totalFrames % walkingAnimation.Count; 

        spriteRenderer.sprite = walkingAnimation[frame];
    }

}
