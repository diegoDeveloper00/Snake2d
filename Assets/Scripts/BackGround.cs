using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Snake>())
        {
            collision.GetComponent<Snake>().isGameOver = true;
            GameManager.getInstance.gameOverCanvase.SetActive(true);
            Destroy(collision.gameObject);
        }
    }

}
