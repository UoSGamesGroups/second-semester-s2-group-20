using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce_Pad : MonoBehaviour {

	public KeyCode Up, Down;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		UserInput ();
	}

	private void UserInput()
	{
		if (Input.GetKey (Up)) {
			transform.Rotate (0, 0, 100 * Time.deltaTime);
		}
		else if (Input.GetKey (Down)) {
			transform.Rotate (0, 0, -100 * Time.deltaTime);
		}
	}
}
