using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float projectileSpeed = 20f;
    public float shotDelay;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;
    public bool canShoot;
    public AudioSource source;
    public AudioClip clip;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire && canShoot)
        {
            nextFire = Time.time + fireRate;

            ShootBase();
            source.PlayOneShot(clip);
        }
    }

    void ShootBase()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * projectileSpeed, ForceMode2D.Impulse);
    }
}
