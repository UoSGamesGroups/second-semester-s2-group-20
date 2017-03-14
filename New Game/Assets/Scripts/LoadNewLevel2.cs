﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewLevel2 : MonoBehaviour 
{
	private int LevelLoader = 0;

	void Start()
	{
		LevelLoader = Random.Range (5, 7);
	}

	void Update () 
	{
		WaitTime ();
	}

	IEnumerator WaitTime()
	{
		yield return new WaitForSeconds (5);
		SceneManager.LoadScene (LevelLoader);
	}
}
