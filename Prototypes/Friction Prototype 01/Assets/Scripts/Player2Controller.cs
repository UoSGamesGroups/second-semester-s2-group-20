using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour {

	public Rigidbody2D rb2d;

	void FixedUpdate ()
	{
		if (Input.GetKey (KeyCode.KeypadEnter)) {
			rb2d.constraints = RigidbodyConstraints2D.FreezeAll;
		}
	}
}