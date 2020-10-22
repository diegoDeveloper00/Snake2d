using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;

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

    public void updateScore(int amount)
    {
        GameManager.getInstance.totalScore += amount;
        scoreText.text = " " + GameManager.getInstance.totalScore;
    }

}
