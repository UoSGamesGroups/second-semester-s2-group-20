using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2_Controller : MonoBehaviour {

	public KeyCode Left, Right;
	public float speed;
	private Vector2 velocity;
	private Vector3 defaultScale;

	void Start () 
	{
		defaultScale = GetComponent<Transform> ().localScale;
	}

	void Update () 
	{
		UserInput ();
		velocity *= Time.deltaTime;
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (velocity.x, GetComponent<Rigidbody2D> ().velocity.y + velocity.y);
		velocity = Vector2.zero;
	}

	private void UserInput()
	{
		if (Input.GetKey(Left))
		{
			velocity.x = -speed;
			GetComponent<Transform> ().localScale = new Vector3 (defaultScale.x, defaultScale.y, defaultScale.z);
		}
		else if (Input.GetKey(Right))
		{
			velocity.x = speed;
			GetComponent<Transform> ().localScale = new Vector3 (-defaultScale.x, defaultScale.y, defaultScale.z);
		}
		else
		{
			velocity.x = 0;
		}
	}
}
