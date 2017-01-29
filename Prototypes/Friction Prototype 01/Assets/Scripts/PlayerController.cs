using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody2D rb2d;

	void FixedUpdate ()
	{
		if (Input.GetKey (KeyCode.Space)) {
			rb2d.constraints = RigidbodyConstraints2D.FreezeAll;
		}
	}
}