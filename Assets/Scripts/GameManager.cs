using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject gameOverCanvase;

    public int scorePerFood;

    public int totalScore;

    public int highScore;

    private static GameManager instance;

    public static GameManager getInstance
    {
        get{
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

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore");
    }

    public void updateHighScore()
    {
        if (totalScore > PlayerPrefs.GetInt("highScore"))
        {
            highScore = totalScore;

            PlayerPrefs.SetInt("highScore", highScore);
        }
    }

    public void reloadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quiGame()
    {
        Application.Quit();
    }

}
