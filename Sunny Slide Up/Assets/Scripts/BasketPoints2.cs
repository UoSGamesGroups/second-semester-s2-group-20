using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketPoints2 : MonoBehaviour{

    public GUIText scoreText1;
    public int score1;

    // Use this for initialization
    void Start()    {
        score1 = 0;
        UpdateScore1();

    }

    // Update is called once per frame
    void UpdateScore1()    {
        scoreText1.text = "Score: " + score1;

    }

    public void AddScore1(int newScoreValue1)
    {
        score1 += newScoreValue1;
        UpdateScore1();
    }
}
