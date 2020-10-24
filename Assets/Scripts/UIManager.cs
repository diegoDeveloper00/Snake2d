using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;

    public Text highScoreText;

    private static UIManager instance;

    public static UIManager getInstance
    {
        get
        {
            if (instance == null)
            {
                Debug.LogError("instance error");
            }
            return instance;
        }


    }


    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        updateHighScoreUI();
    }

    public void updateScore(int amount)
    {
        GameManager.getInstance.totalScore += amount;
        scoreText.text = " " + GameManager.getInstance.totalScore;
    }

    public void updateHighScoreUI()
    {
        int highscoreSaved = PlayerPrefs.GetInt("highScore");
        highScoreText.text = " " + highscoreSaved;
    }

}
