using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie2 : MonoBehaviour
{
    int direction = 1;
    public float speed = 1.0f;
    Vector3 pos1;
    Vector3 pos2;
   
    void Update()
    {
        pos1 = new Vector3(0.0f, 0.0f, 0.0f);
        pos2 = new Vector3(10.0f, 0.0f, 0.0f);

        if (transform.position.x <= pos1.x)
        {
            direction = 1;
        }
        if(transform.position.x >= pos2.x)
        {
            direction = 2;
        }
        if (direction == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, pos2, speed * Time.deltaTime);
        }
        if (direction == 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, pos1, speed * Time.deltaTime);
        }
    }
}

   
