using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score = 0;
    //public TextMeshProUGUI scoreUI;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        //scoreUI.text = score.ToString();
        GetComponent<TextMeshProUGUI>().text = score.ToString();
    }
}
