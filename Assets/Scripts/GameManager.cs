using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject gameOverCanvase;

    public int scorePerFood;

    public int totalScore;

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

}
