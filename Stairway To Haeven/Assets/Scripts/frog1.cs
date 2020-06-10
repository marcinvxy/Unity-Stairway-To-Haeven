using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frog1 : MonoBehaviour
{
    private float x = 0.01f;
    public GameObject gameOverPanel;

    void Start()
    {
        transform.position = new Vector3(-3.40f, 0.34f, 0);
        gameOverPanel.gameObject.SetActive(false);
    }

    void Update()
    {
        if (transform.position.x > -1.45)
        {
            x = -0.01f;
        }
        else if(transform.position.x < -3.45)
        {
            x = 0.01f;
        }
        transform.position = transform.position + new Vector3(x, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameOverPanel.gameObject.SetActive(true);
            Destroy(other.gameObject);
        }
    }
}