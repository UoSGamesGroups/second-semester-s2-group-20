using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpanwer : MonoBehaviour {
	public Transform[] spawnLocations;
	public GameObject[] SpawnPrefab;
	public GameObject[] SpawnClone;
	public float spawnTime = 3f;

	void Start(){
		InvokeRepeating ("spawneggs", spawnTime, spawnTime);
	}

	void spawneggs()
	{
		SpawnClone [0] = Instantiate (SpawnPrefab[0], spawnLocations[0].transform.position,Quaternion.Euler(0,0,0)) as GameObject;
		SpawnClone [1] = Instantiate (SpawnPrefab[1], spawnLocations[1].transform.position,Quaternion.Euler(0,0,0)) as GameObject;
		SpawnClone [2] = Instantiate (SpawnPrefab[2], spawnLocations[2].transform.position,Quaternion.Euler(0,0,0)) as GameObject;

	}
}