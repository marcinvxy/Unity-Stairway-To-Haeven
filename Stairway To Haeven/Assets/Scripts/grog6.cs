using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grog6 : MonoBehaviour
{
    private float x = 0.01f;
    public GameObject gameOverPanel;

    void Start()
    {
        transform.position = new Vector3(4.56f, 48.34f, 0);
        gameOverPanel.gameObject.SetActive(false);
    }

    void Update()
    {
        if (transform.position.x > 5.6)
        {
            x = -0.01f;
        }
        else if (transform.position.x < 4.56)
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
