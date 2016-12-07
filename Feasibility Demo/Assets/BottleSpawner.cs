using UnityEngine;
using System.Collections;

public class BottleSpawner : MonoBehaviour {

	public GameObject bottle;
	float spawnTimer = 0.0f;

	// Use this for initialization
	void Start () 
	{
		spawnBottle();
	}
	
	// Update is called once per frame
	void Update () 
	{
		spawnTimer += Time.deltaTime;

		if (spawnTimer >= 2.0f)
		{
			spawnBottle();
			spawnTimer = 0.0f;
		}
	}

	void spawnBottle()
	{
		Instantiate(bottle, transform.position, Quaternion.identity);
	}
}
