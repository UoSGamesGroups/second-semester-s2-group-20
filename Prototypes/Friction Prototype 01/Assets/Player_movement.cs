using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour {

	public KeyCode W, S, A, D;
	public float speed;

	private Vector3 defaultScale;
	private Vector2 velocity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		if (Input.GetKey (A)) {
			velocity.x = -speed;
			GetComponent<Transform> ().localScale = new Vector3 (-defaultScale.x, defaultScale.y, defaultScale.z);
		} else if (Input.GetKey (D)) {
			velocity.x = speed;
			GetComponent<Transform> ().localScale = new Vector3 (defaultScale.x, defaultScale.y, defaultScale.z);
		} else
			velocity.x = 0;
	}
}
