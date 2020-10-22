using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Snake : MonoBehaviour
{
    Vector2 gridPosition;
    Vector2 gridDirection;
    public GameObject snakeTail;
    GameObject tail;
    List<Transform> tailList;
    public bool eat = false;
    bool horizontal = false;
    bool vertical = true;
    public bool isGameOver = false;
    // Start is called before the first frame update
    void Awake()
    {
        gridPosition = new Vector2(10, 10);
        transform.position = gridPosition;
        tailList = new List<Transform>();
    }

    private void Start()
    {
        if (isGameOver) { return; }
        else if (!isGameOver)
        {
            InvokeRepeating("Movement", 0.1f, 0.1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver) { return; }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (!vertical)
            {
                gridDirection = new Vector2(0, 1);
            }
            vertical = true;
            horizontal = false;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (!vertical)
            {
                gridDirection = new Vector2(0, -1);
            }
            vertical = true;
            horizontal = false;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (!horizontal)
            {
                gridDirection = new Vector2(1, 0);
            }
            vertical = false;
            horizontal = true;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (!horizontal)
            {
                gridDirection = new Vector2(-1, 0);
            }
            vertical = false;
            horizontal = true;
        }
    }

    private void Movement()
    {
        if (eat)
        {
            tailList.Insert(0, tail.transform);
            eat = false;
        }
        else if (tailList.Count > 0) {
            tailList.Last().position = transform.position;
            tailList.Insert(0, tailList.Last());
            tailList.RemoveAt(tailList.Count - 1);
        }
       
        gridPosition += gridDirection;
        transform.position = new Vector2(gridPosition.x, gridPosition.y);
        
    }
    public void grow()
    {
            tail = Instantiate(snakeTail, gridPosition, Quaternion.identity);
    }
}
