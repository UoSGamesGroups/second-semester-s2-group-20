using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg_Destroyer : MonoBehaviour {

	public float timer;

	void Update () 
	{
		timer += 1.0f * Time.deltaTime;
		if (timer >= 5) 
		{
			GameObject.Destroy (gameObject);
	}
}
}