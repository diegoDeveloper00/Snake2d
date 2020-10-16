using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{

    public GameObject food;
    // Start is called before the first frame update
    void Start()
    {
        spawnFood();
    }

   public void spawnFood()
    {
        Vector2 foodPos = new Vector2(Random.Range(1, 19), Random.Range(1, 19));
        Instantiate(food, foodPos, Quaternion.identity);
    }
}
