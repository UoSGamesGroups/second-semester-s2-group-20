using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
	public float timeLeft = 100.0f;
	public GUIText text;
	public int SceneID;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		text.text = "" + Mathf.Round (timeLeft);
		if (timeLeft < 0) {
			SceneManager.LoadScene (SceneID);
		}
		
	}
}
