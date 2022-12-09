using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxTime = 1f;
    private float timer = 0;
    public GameObject pipe;
    public float minHeight;
    public float maxHeight;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime) {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(10, Random.Range(minHeight, maxHeight),0);
            Destroy(newpipe, 5);
            timer = 0; 
        }
        timer += Time.deltaTime;
    }
}
