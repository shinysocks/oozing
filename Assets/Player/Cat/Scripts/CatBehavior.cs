using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CatBehavior : MonoBehaviour
{
    // Cat Body Transformation References (Unity)
    public Rigidbody2D body;    
    public SpriteRenderer spriteRenderer;
    
    // Changeable values
    public float walkSpeed;
    public float frameRate;
    public float rotationSpeed;

    // Lists of Different Directions
    public List<Sprite> walkingAnimation;
    public List<GameObject> screenGunks;

    // Other references

    public GameObject bullet;

    public GameObject hitEffect;

    public GameObject UiObject;
    public int Gunkiness;

    // Private variables
    Vector2 directionWithSpeed;


// Unity Functions==========================
    void Start()
    {
        UiObject.SetActive(false);
    }

    void Update()
    {
        DeathDetection();
        Animate();
        Rotate();
        Gunkify();
    }


    void FixedUpdate()
    {
        Move();
    }


    // Functions
    void Move()
    {
        // get direction
        Vector2 direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;

        // move based on direction
        directionWithSpeed = direction * walkSpeed;
        body.velocity = directionWithSpeed;
    }


    void Rotate()
    {
        if (directionWithSpeed.x < 0 && directionWithSpeed.y > 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 45.0f), Time.deltaTime * rotationSpeed);
        }

        else if (directionWithSpeed.x < 0 && directionWithSpeed.y == 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 90.0f), Time.deltaTime * rotationSpeed);
        }

        else if (directionWithSpeed.x < 0 && directionWithSpeed.y < 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 135.0f), Time.deltaTime * rotationSpeed);
        }

        else if (directionWithSpeed.x == 0 && directionWithSpeed.y < 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 180.0f), Time.deltaTime * rotationSpeed);
        }

        else if (directionWithSpeed.x > 0 && directionWithSpeed.y < 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 225.0f), Time.deltaTime * rotationSpeed);
        }

        else if (directionWithSpeed.x > 0 && directionWithSpeed.y == 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 270.0f), Time.deltaTime * rotationSpeed);
        }

        else if (directionWithSpeed.x > 0 && directionWithSpeed.y > 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 315.0f), Time.deltaTime * rotationSpeed);
        }

        else if (directionWithSpeed.x == 0 && directionWithSpeed.y > 0) 
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 0.0f), Time.deltaTime * rotationSpeed);
        }
    }


    void Animate()
    {
        if (!(directionWithSpeed.x == 0 && directionWithSpeed.y == 0)) // actually moving? how does this work???
        {
            float playTime = Time.time;
            int totalFrames = (int)(playTime * frameRate);
            int frame = totalFrames % walkingAnimation.Count; 

            spriteRenderer.sprite = walkingAnimation[frame];
        }

        else
        {
            spriteRenderer.sprite = walkingAnimation[2];
        }
    }

    void DeathDetection()
    {
        if (Gunkiness > 5)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("End");
        Time.timeScale = 1;
    }


    void OnTriggerExit(Collider other)
    {
        UiObject.SetActive(false);
    }

    void Gunkify()
    {
        //AllGunks.SetActive(false);
        switch(Gunkiness) 
        {
        case 1:
            screenGunks[0].SetActive(true);
            break;
        case 2:
            screenGunks[1].SetActive(true);
            break;
        case 3:
            screenGunks[2].SetActive(true);
            break;
        case 4:
            screenGunks[3].SetActive(true);
            break;
        case 5:
            screenGunks[4].SetActive(true);
            break;
        }
    }
}
