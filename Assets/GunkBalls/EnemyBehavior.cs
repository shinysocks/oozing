using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public Transform player;
    private Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    public float moveSpeed = 5;
    private Vector2 movement;

    public GameObject enemyPrefab;
    int enemyHealth = 0;

    // Animation
    public List<Sprite> walkingAnimation;
    public float frameRate;
    bool moving = true;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        enemyHealth = Random.Range(1, 4);
    }

    void Update() 
    {
        Animate();

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Cannonball")
        {
            enemyHealth -= 1;
            if (enemyHealth <= 0)

            {
                Destroy(gameObject);
            }
        }

        if (other.gameObject.tag == "Cat")
        {
            Destroy(gameObject);
            // pop animation 
        }
    }
    
    void Animate()
    {
        if (moving) // actually moving? how does this work???
        {
            float playTime = Time.time;
            int totalFrames = (int)(playTime * frameRate);
            int frame = totalFrames % walkingAnimation.Count; 

            spriteRenderer.sprite = walkingAnimation[frame];
        }

        else
        {
            spriteRenderer.sprite = walkingAnimation[0];
        }
    }

}
