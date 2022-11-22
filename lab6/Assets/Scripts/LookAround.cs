using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LookAround : MonoBehaviour
{
    public Transform player;
    float minX = -90f;
    float maxX = 90f;
    float xRotation;
    public float sensitivity = 200f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseYMove = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= mouseYMove;
        xRotation = Mathf.Clamp(xRotation, minX, maxX);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * mouseXMove);
    }
}