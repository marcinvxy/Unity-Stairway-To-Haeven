using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Rigidbody2D rb;
    private float y;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(0, 0, -10f);
    }

    void Update()
    {
        if (transform.position.y > -0.8)
        {
            rb.velocity = new Vector2(0, player.instance.y);
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }
    }
}
