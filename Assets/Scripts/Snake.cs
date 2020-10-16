using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    Vector2 gridPosition;
    Vector2 gridDirection;
   public float snakeSpeed=7f;
    public GameObject snakeTail;
    GameObject tail;
    // Start is called before the first frame update
    void Awake()
    {
        gridPosition = new Vector2(10, 10);
        transform.position = gridPosition;
        gridDirection = new Vector2(1, 0)*Time.deltaTime*7;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            gridDirection = new Vector2(0, 1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            gridDirection = new Vector2(0, -1);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            gridDirection = new Vector2(1, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gridDirection = new Vector2(-1, 0);
        }
        gridPosition += gridDirection * Time.deltaTime * snakeSpeed;
        transform.position = new Vector2(gridPosition.x, gridPosition.y);
    }
}
