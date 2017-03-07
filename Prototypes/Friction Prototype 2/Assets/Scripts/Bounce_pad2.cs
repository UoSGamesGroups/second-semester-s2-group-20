using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce_pad2 : MonoBehaviour {
	
	public KeyCode W, S;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		UserInput ();
	}

	private void UserInput()
	{
		if (Input.GetKey (W)) {
			transform.Rotate (0, 0, 100 * Time.deltaTime);
		}
		else if (Input.GetKey (S)) {
			transform.Rotate (0, 0, -100 * Time.deltaTime);
		}
	}
}
