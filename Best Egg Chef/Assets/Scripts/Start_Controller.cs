using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Controller : MonoBehaviour {

	public KeyCode rotateup;
	public KeyCode rotateDown;
	public float rotateSpeed = 0.5f;

	void Start()
	{
		StartCoroutine (Change ());
	}

	IEnumerator Change()
	{
		yield return new WaitForSeconds (3);
		rotateSpeed = 0f;
	}

	void FixedUpdate()
	{
		if (Input.GetKey (rotateup))
			transform.Rotate (new Vector3 (0, 0, rotateSpeed));

		if (Input.GetKey (rotateDown))
			transform.Rotate (new Vector3 (0, 0, -rotateSpeed));
	}
}