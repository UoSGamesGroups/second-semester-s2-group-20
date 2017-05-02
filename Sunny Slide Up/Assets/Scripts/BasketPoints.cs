using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketPoints : MonoBehaviour {

    public GUIText scoreText;
    public int score;

	// Use this for initialization
	void Start () {
        score = 0;
        UpdateScore();
		
	}
	
	// Update is called once per frame
	void UpdateScore () {
        scoreText.text = "Score: " + score;
		
	}

    public void AddScore (int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }
}
