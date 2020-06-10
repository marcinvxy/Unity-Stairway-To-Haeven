using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frog5 : MonoBehaviour
{
    private float x = -0.01f;
    public GameObject gameOverPanel;

    void Start()
    {
        transform.position = new Vector3(-0.56f, 46.342f, 0);
        gameOverPanel.gameObject.SetActive(false);
    }

    void Update()
    {
        if (transform.position.x > 0.6)
        {
            x = -0.01f;
        }
        else if (transform.position.x < -0.56)
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
