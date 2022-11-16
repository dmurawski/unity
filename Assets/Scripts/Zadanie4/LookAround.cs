using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LookAround : MonoBehaviour
{
    // ruch wokó³ osi Y bêdzie wykonywany na obiekcie gracza, wiêc
    // potrzebna nam referencja do niego (konkretnie jego komponentu Transform)
    public Transform player;
    float minX = -90f;
    float maxX = 90f;
    float xRotation;
    public float sensitivity = 200f;

    void Start()
    {
        // zablokowanie kursora na œrodku ekranu, oraz ukrycie kursora
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // pobieramy wartoœci dla obu osi ruchu myszy
        float mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseYMove = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= mouseYMove;
        xRotation = Mathf.Clamp(xRotation, minX, maxX);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * mouseXMove);

        //limit = Math.Clamp(mouseXMove, minX, maxX);
        // a dla osi X obracamy kamerê dla lokalnych koordynatów
        // -mouseYMove aby unikn¹æ ofektu mouse inverse
        //if (limit <= -90 && limit >= 90)
          //  transform.Rotate(new Vector3(-mouseYMove, 0f, 0f), Space.Self);
    //    player.Rotate(Vector3.up * mouseXMove);
    }
}