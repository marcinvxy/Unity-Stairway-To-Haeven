using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private SpriteRenderer toggle;
    public Sprite mySprite;
    public GameObject gameOverPanel;
   
    void Start()
    {
        toggle = GetComponent<SpriteRenderer>();
        gameOverPanel.gameObject.SetActive(false);
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            toggle.sprite = mySprite;
            gameOverPanel.gameObject.SetActive(true);
            Destroy(other.gameObject);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
