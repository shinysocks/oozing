using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollide : MonoBehaviour
{
    public GameObject hitEffect;
    public GameObject bullet;
    public GameObject bulletPrefab;
    public bool multiShot = true;
    public float projectileSpeed;

    void Start()
    {
        Physics2D.IgnoreLayerCollision(10, 13, true);

        projectileSpeed = 10;

    }

    void Update()
    {
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (multiShot == false)
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.3f);
            Destroy(gameObject);
        }
    }

}
