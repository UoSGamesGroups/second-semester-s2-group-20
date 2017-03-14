using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OnClick : MonoBehaviour 
{

	private int LevelLoader = 0;

	void Start()
	{
		LevelLoader = Random.Range (2, 4);
	}

	public void sceneChanger()
	{
		SceneManager.LoadScene(LevelLoader);
	}

	public void exitGame()
	{
		Application.Quit ();
	}
}
