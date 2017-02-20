using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinCheck : MonoBehaviour 
{
	public bool hasEnterPressed = false;
	public bool hasSpacePressed = false;

	private bool isRunning = true;

	public Transform player1;
	public Transform player2;
	public Transform player1Goal;
	public Transform player2Goal;

	public Text p1win;
	public Text p2win;

	public float player1Distance;
	public float player2Distance;

	public int player1Score;
	public int player2Score;

	void Start()
	{
		p1win.enabled = false;
		p2win.enabled = false;
	}

	void Update () 
	{
		player1Distance = Vector2.Distance (player1.position, player1Goal.position);
		player2Distance = Vector2.Distance (player2.position, player2Goal.position);
		//Debug.Log (player1Distance);

		if (Input.GetKeyDown ("space"))
			hasSpacePressed = true;

		if (Input.GetKeyDown ("return"))
			hasEnterPressed = true;

		if (hasEnterPressed == true && hasSpacePressed == true) 
		{
			if (isRunning == true) 
			{
				isRunning = false;
				CalculatePlayer1Score ();
				CalculatePlayer2Score ();

				if (player1Distance < player2Distance) 
				{
					p1win.enabled = true;
					player1Score = player1Score + 2;
				}

				if (player2Distance < player1Distance) 
				{
					p2win.enabled = true;
					player2Score = player2Score + 2;
				}
			}
		}
	}

	void CalculatePlayer1Score()
	{
		if (player1Distance <= 15 && player1Distance > 5)
			player1Score = player1Score + 0;
		if (player1Distance <= 5 && player1Distance > 4)
			player1Score = player1Score + 1;
		if (player1Distance <= 4 && player1Distance > 3)
			player1Score = player1Score + 2;
		if (player1Distance <= 3 && player1Distance > 2)
			player1Score = player1Score + 3;
		if (player1Distance <= 2 && player1Distance > 1)
			player1Score = player1Score + 4;
		if (player1Distance <= 1)
			player1Score = player1Score + 7;
	}

	void CalculatePlayer2Score()
	{
		if (player2Distance <= 15 && player2Distance > 5)
			player2Score = player2Score + 0;
		if (player2Distance <= 5 && player2Distance > 4)
			player2Score = player2Score + 1;
		if (player2Distance <= 4 && player2Distance > 3)
			player2Score = player2Score + 2;
		if (player2Distance <= 3 && player2Distance > 2)
			player2Score = player2Score + 3;
		if (player2Distance <= 2 && player2Distance > 1)
			player2Score = player2Score + 4;
		if (player2Distance <= 1)
			player2Score = player2Score + 7;
	}
}
