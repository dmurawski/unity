using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie3 : MonoBehaviour
{
    int direction = 1;
    public float speed = 1.0f;
    Vector3 pos1;
    Vector3 pos2;
    Vector3 pos3;
    Vector3 pos4;

    void Update()
    {
        pos1 = new Vector3(0.0f, 0.0f, 0.0f);
        pos2 = new Vector3(10.0f, 0.0f, 0.0f);
        pos3 = new Vector3(10.0f, 0.0f, 10.0f);
        pos4 = new Vector3(0.0f, 0.0f, 10.0f);

        if (direction == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, pos2, speed * Time.deltaTime);
            if (transform.position.x == pos2.x)
            {
                transform.Rotate(0, -90, 0, Space.Self);
                direction = 2;
            }
        }
        
        if (direction == 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, pos3, speed * Time.deltaTime);
            if (transform.position.z == pos3.z)
            {
                transform.Rotate(0, -90, 0, Space.Self);
                direction = 3;
            }
        }
        
        if (direction == 3)
        {
            transform.position = Vector3.MoveTowards(transform.position, pos4, speed * Time.deltaTime);
            if (transform.position.x == pos4.x)
            {
                transform.Rotate(0, -90, 0, Space.Self);
                direction = 4;
            }
        }
        if (direction == 4)
        {
            transform.position = Vector3.MoveTowards(transform.position, pos1, speed * Time.deltaTime);
            if (transform.position.z == pos1.z)
            {
                transform.Rotate(0, -90, 0, Space.Self);
                direction = 1;
            }
        }

    }
}
