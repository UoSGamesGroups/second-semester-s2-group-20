using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour {

	public KeyCode rotateup;
	public KeyCode rotatedown;
	public KeyCode debuff;
	public float rotatespeed = 1.5f;
	public float movespeed = 1f;
	public Rigidbody2D rb2d;
	public GameObject enemy;

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate ()
	{
		if (Input.GetKey (rotateup))
			transform.Rotate (new Vector3 (0, 0, rotatespeed));

		if (Input.GetKey (rotatedown))
			transform.Rotate (new Vector3 (0, 0, -rotatespeed));

		float movehorizontal = Input.GetAxis ("P1Horizontal");
		Vector3 movement = new Vector3 (movehorizontal, 0, 0);
		rb2d.AddForce (movement * movespeed);

		if (Input.GetKey (debuff))
			enemy.GetComponent<Collider2D>().sharedMaterial.bounciness = 2;
		enemy.GetComponent<Collider2D>().sharedMaterial.friction = 0;

	}
}