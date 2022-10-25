using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    public Transform target;
    float smoothTime = 0.3f;

    void Update()
    {
        float newPosition = Mathf.Lerp(transform.position.y, target.position.y, smoothTime);
        transform.position = new Vector3(transform.position.x, newPosition, transform.position.z);
    }
}
