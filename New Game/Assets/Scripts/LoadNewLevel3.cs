﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewLevel3 : MonoBehaviour 
{
	private int LevelLoader = 0;

	void Start()
	{
		LevelLoader = Random.Range (8, 10);
        StartCoroutine(WaitTime());
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(LevelLoader);
    }
}