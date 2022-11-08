using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LookAround : MonoBehaviour
{
    // ruch wok� osi Y b�dzie wykonywany na obiekcie gracza, wi�c
    // potrzebna nam referencja do niego (konkretnie jego komponentu Transform)
    public Transform player;
    float minX = -90f;
    float maxX = 90f;
    public float sensitivity = 200f;

    void Start()
    {
        // zablokowanie kursora na �rodku ekranu, oraz ukrycie kursora
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // pobieramy warto�ci dla obu osi ruchu myszy
        float mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseYMove = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        
        player.Rotate(Vector3.up * mouseXMove);
        mouseXMove = Math.Clamp(mouseXMove, minX, maxX);
        // a dla osi X obracamy kamer� dla lokalnych koordynat�w
        // -mouseYMove aby unikn�� ofektu mouse inverse
        if (mouseXMove >= -90 && mouseXMove <= 90)
            transform.Rotate(new Vector3(-mouseYMove, 0f, 0f), Space.Self);

    }
}