using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skrzynia : MonoBehaviour
{

    public float force = 5.0f;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 0, force, ForceMode.Impulse);
    }
}
