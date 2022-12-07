using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    ScoreManager _instance;
    public GameObject winScreen;
    public TMP_Text scoreText;

    int score = 0;
    public int winningScore = 15;
    // Start is called before the first frame update
    void Start()
    {
        if (_instance == null)
            _instance = this;
        else
            Destroy(this);
    }

    public void IncreaseScore(int amount)
    {
        score += amount;

        scoreText.text = "Score: " + score;

        if (score >= winningScore)
        {
            WonGame();
        }
    }

    public void DecreaseScore(int amount)
    {
        score -= amount;

        if (score <= 0)
            score = 0;
    }

    public void WonGame()
    {
        winScreen.SetActive(true);
        Time.timeScale = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

