using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score_System : MonoBehaviour {

	private int score;
	public Text scoreText;
	public BoxCollider2D bc;

	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Egg") {
			UpdateScore ();
		}
	}

	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}

	void UpdateScore ()
	{
		scoreText.text = "Score: " + score;
	}
			
}
