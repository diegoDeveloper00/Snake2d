using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit: " + collision.name);
        if (collision.GetComponent<Snake>())
        {
            Destroy(gameObject);
            FindObjectOfType<SpawnFood>().spawnFood();
            collision.GetComponent<Snake>().eat = true;
            UIManager.getInstance.updateScore(GameManager.getInstance.scorePerFood);
            GameManager.getInstance.updateHighScore();
            collision.GetComponent<Snake>().grow();
        }
    }
}
