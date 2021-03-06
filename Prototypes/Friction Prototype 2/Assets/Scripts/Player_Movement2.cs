﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement2: MonoBehaviour {

	public KeyCode A, E, D;
	public float speed;
	public GameObject P1;
	public Rigidbody2D P1speed;
	private Vector2 velocity;
	private Vector3 defaultScale;

	// Use this for initialization
	void Start () {
		defaultScale = GetComponent<Transform> ().localScale;
		P1speed = P1.GetComponent<Rigidbody2D>();

	}

	// Update is called once per frame
	void Update () {
		UserInput ();
		velocity *= Time.deltaTime;
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (velocity.x, GetComponent<Rigidbody2D> ().velocity.y + velocity.y);
		velocity = Vector2.zero;
	}

	private void UserInput()
	{
		if (Input.GetKey (A)) {
			velocity.x = -speed;
			GetComponent<Transform> ().localScale = new Vector3 (-defaultScale.x, defaultScale.y, defaultScale.z);
		} else if (Input.GetKey (D)) {
			velocity.x = speed;
			GetComponent<Transform> ().localScale = new Vector3 (defaultScale.x, defaultScale.y, defaultScale.z);
		} else {
			velocity.x = 0;
		}

		if (Input.GetKey (E)) {
			P1speed.drag = 175;
			StartCoroutine (Fast ());
		}
	}

	IEnumerator Fast()
	{
		yield return new WaitForSeconds (2);
		P1speed.drag = 0;
	}
}
