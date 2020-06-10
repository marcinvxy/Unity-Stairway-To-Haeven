using System;
using System.Collections;
using UnityEngine;

public class player : MonoBehaviour
{
    private bool ground = false;
    Rigidbody2D rb;
    public float y;
    public static player instance;

    void Awake()
    {
        instance = this;
    }
 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    { 
        rb.velocity = new Vector2(Input.acceleration.x * 10f, rb.velocity.y);
        y = rb.velocity.y;
        if (Input.touchCount == 1);
        {
            if (ground == true)
            {
                Touch touch = Input.GetTouch(0);
                rb.AddForce(Vector2.up * 10f, ForceMode2D.Impulse);
                ground = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Box")
        {
            ground = true;
        }
    }
}