using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreText;

    public int score = 0;
    public int bestScore = 0;

    public void Awake()
    {

        Instance = this;


    }
    void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScore", 0);
        scoreText.text = "Score: " + score.ToString();
        bestScoreText.text = "Best Score: " + bestScore.ToString();
    }

    
    void Update()
    {
        
    }

    public void ScoreUp()
    {         score++;
        scoreText.text = "Score: " + score.ToString();
        if (score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetInt("BestScore", bestScore);
            bestScoreText.text = "Best Score: " + bestScore.ToString();
        }
    }
}
