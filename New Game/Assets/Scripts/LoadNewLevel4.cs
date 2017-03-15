using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewLevel4 : MonoBehaviour 
{
	private int LevelLoader = 0;

	void Start()
	{
		LevelLoader = Random.Range (11, 13);
        StartCoroutine(WaitTime());
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(LevelLoader);
    }
}