using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class Distance_print : MonoBehaviour{
	public Transform player; 
	public Rigidbody2D rb1; 
	public Rigidbody2D rb2;
	float Player1X; 
	float Player2X;
	public string information1; 
	public string information2;

	public Text Text;  

	public Text Textp2;

	public float distance;


	void Update()
	{
		Player1X = rb1.position.x; 
		Player2X = rb2.position.x;
		information1 = Player1X.ToString ("F2"); 
		information2 = Player2X.ToString ("F2");
		Text.text = "Player 1 " + information1;
		Textp2.text = "Player 2 " + information2;
	}
}