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
        }
    }
}
