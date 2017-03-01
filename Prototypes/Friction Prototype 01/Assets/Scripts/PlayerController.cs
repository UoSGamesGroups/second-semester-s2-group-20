using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody2D rb2d;
	public KeyCode Space;

	void Start()
	{
	}

	void FixedUpdate ()
	{
		if (Input.GetKey (Space)) {
			rb2d.constraints = RigidbodyConstraints2D.FreezeAll;
			StartCoroutine (Go ());
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

		if (collision.gameObject.tag == "Marker") {
			StartCoroutine (Change ());
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

	IEnumerator Change()
	{
		yield return new WaitForSeconds (3);
		Application.LoadLevel (Random.Range (0, 5));
	}

	IEnumerator Go()
	{
		yield return new WaitForSeconds (3);
		rb2d.constraints = RigidbodyConstraints2D.None;
	}
}