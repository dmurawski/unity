using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie5 : MonoBehaviour
{
    public GameObject prefab;
    int numberOfObjects = 10;
    float spawnCollisionCheckRadius = 0.0f;
    void Start()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-9, 9), 1, Random.Range(-9, 9));
            if (!Physics.CheckSphere(randomSpawnPosition, spawnCollisionCheckRadius))
            {
                Instantiate(prefab, randomSpawnPosition, Quaternion.identity);
            }
            else
            {
                i--;
            }

            }
        }
    }
