using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject GameOver;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        GameOver.SetActive(false);
    }

    // Update is called once per frame
    public void over()
    {
        GameOver.SetActive(true);
        Time.timeScale = 0;
        
    }
}
