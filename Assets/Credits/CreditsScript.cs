using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class CreditsScript : MonoBehaviour
{
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.gravityScale = -25f;
        }
    }
}