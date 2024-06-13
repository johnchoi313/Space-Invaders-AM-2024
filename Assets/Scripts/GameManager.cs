using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text healthText;
    public TMP_Text scoreText;

    public int health = 5;
    public int score = 0;

    public GameObject YouWinObject;
    public GameObject GameOverObject;

    public void IncreaseScore(int amount)
    {
        score = score + amount;
        if(score >= 5) { ActivateYouWin(); }
    }
    public void DecreaseHealth(int amount)
    {
        health = health - amount;
        if(health <= 0) { ActivateGameOver(); }
    }
    public void ActivateYouWin()
    {
        YouWinObject.SetActive(true);
    }
    public void ActivateGameOver()
    {
        GameOverObject.SetActive(true);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("Space Invaders");
    }

    // Start is called before the first frame update
    void Start()
    {
        YouWinObject.SetActive(false);
        GameOverObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + health;
        scoreText.text = "Score: " + score;
    }

}
