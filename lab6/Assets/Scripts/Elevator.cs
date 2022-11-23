using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Elevator : MonoBehaviour
{
    public bool canMove=false;
    public float speed;
    public int startPoint;
    public Transform[] points;
    int i;
    bool reverse;
    public bool setparent = false;

    void Start()
    {
        transform.position = points[startPoint].position;
        i = startPoint;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, points[i].position) < 0.01f)
        {
            if (i == points.Length - 1)
            {
                reverse = true;
                i--;
                return;
            }
            else if (i == 0)
            {
                reverse = false;
                i++;
                return;
            }
            if (reverse)
            {
                i--;
            }
            else
            {
                i++;
            }
        }
        if (canMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (setparent == true)
            {
                other.transform.SetParent(transform);
                canMove = true;
            }
            Debug.Log("rodzic ustawiony.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player zszed³ z windy.");
            Debug.Log("rodzic usuniety.");
            other.transform.SetParent(null);
            canMove = false;
        }
    }
}