using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Egg_Spawner : MonoBehaviour {

	public Transform[] spawnLocations;
	public GameObject[] spawnClone;
	public GameObject[] spawnPrefab;
	public float spawnTime = 3f;

	void Start () 
	{
		InvokeRepeating ("spawnEggs", spawnTime, spawnTime);
	}

	void spawnEggs() 
	{
		spawnClone [Random.Range (0, 5)] = Instantiate (spawnPrefab [Random.Range (0, 5)], spawnLocations [Random.Range (0, 5)].transform.position, Quaternion.Euler (0, 0, 0)) as GameObject;
		spawnClone [Random.Range (0, 5)] = Instantiate (spawnPrefab [Random.Range (0, 5)], spawnLocations [Random.Range (0, 5)].transform.position, Quaternion.Euler (0, 0, 0)) as GameObject;
		spawnClone [Random.Range (0, 5)] = Instantiate (spawnPrefab [Random.Range (0, 5)], spawnLocations [Random.Range (0, 5)].transform.position, Quaternion.Euler (0, 0, 0)) as GameObject;
	}
}