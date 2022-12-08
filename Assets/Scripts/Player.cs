using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float strenght = 1f;
    private Rigidbody2D rb2D;
    public GameManager gM;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.velocity = Vector2.up * strenght;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gM.over();
    }
}
