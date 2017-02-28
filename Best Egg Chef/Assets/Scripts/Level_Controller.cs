using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Controller : MonoBehaviour 
{
	void Start()
	{
		StartCoroutine (Change ());
	}

	IEnumerator Change()
	{
		yield return new WaitForSeconds (8);
		SceneManager.LoadScene("Main_Sequence");
	}
}