using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frog7 : MonoBehaviour
{
    private float x = -0.01f;
    public GameObject gameOverPanel;

    void Start()
    {
        transform.position = new Vector3(-3.36f, 11.35f, 0);
        gameOverPanel.gameObject.SetActive(false);
    }

    void Update()
    {
        if (transform.position.x > -3.36)
        {
            x = -0.01f;
        }
        else if (transform.position.x < -5.576)
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
