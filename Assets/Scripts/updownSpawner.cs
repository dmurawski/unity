using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updownSpawner : MonoBehaviour
{
    public float maxTime = 1f;
    private float timer = 0;
    public GameObject updown;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newupdown = Instantiate(updown);
            newupdown.transform.position = transform.position + new Vector3(10, 0, -30);
            Destroy(newupdown, 5);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
