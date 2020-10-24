﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Snake>())
        {
            collision.GetComponent<Snake>().isGameOver = true;
            collision.GetComponent<SpriteRenderer>().color = new Color(255, 0, 0, 255);
            GameManager.getInstance.gameOverCanvase.SetActive(true);
        }
    }

}
