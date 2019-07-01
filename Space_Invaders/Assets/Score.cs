//Score.cs
//Created: 7/1/2019
//Owner: Siddharth

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    Text text;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(text)
        {
            text.text = "Score: " + score.ToString();
        }
    }

    public static void AddScore(int points)
    {
        score += points;
    }
}
