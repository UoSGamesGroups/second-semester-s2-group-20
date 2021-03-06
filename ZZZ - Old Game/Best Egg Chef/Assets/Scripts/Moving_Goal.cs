using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Goal : MonoBehaviour {
	public Vector2 velocity;
	public Rigidbody2D rb2D;
	public KeyCode Space, Enter;

	// Use this for initialization
	void Start () {
		rb2D = GetComponent<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb2D.MovePosition (rb2D.position + velocity * Time.fixedDeltaTime);		
	}

	void Update()
	{
		if (Input.GetKey (Space)) {
			rb2D.constraints = RigidbodyConstraints2D.FreezeAll;
		}

		if (Input.GetKey (Enter)) {
			rb2D.constraints = RigidbodyConstraints2D.FreezeAll;
		}
	}
}
