﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour {

	public Rigidbody2D rb2d;

	void FixedUpdate ()
	{
		if (Input.GetKey (KeyCode.Space)) {
			rb2d.constraints = RigidbodyConstraints2D.FreezeAll;
		}
	}

	public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Ice") {
			GetComponent<Rigidbody2D> ().gravityScale = 20;
		}

		if (collision.gameObject.tag == "Glue") {
			rb2d.drag = 2;
		}
	}

	public void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Ice")
		{
			GetComponent<Rigidbody2D> ().gravityScale = 2;
		}

		if (collision.gameObject.tag == "Glue") {
			rb2d.drag = 0;
		}
	}
}